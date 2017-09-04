using Entitas;
using IListExtensions;


public class AddFloorSystem : ReactiveSystem<GameEntity>, IInitializeSystem
{
	private readonly GameContext _context;

	public AddFloorSystem(Contexts contexts) : base(contexts.game)
	{
		_context = contexts.game;
	}


	private readonly Prefab[] WALLS = {
		Prefab.Wall1,
		Prefab.Wall2,
		Prefab.Wall3,
		Prefab.Wall4,
		Prefab.Wall5,
		Prefab.Wall6,
		Prefab.Wall7,
		Prefab.Wall8,
	};


	public void Initialize()
	{
		// FIXME do we really need them?
//		_context.SetViewContainer(new GameObject("Views").transform);
//		_context.SetNestedViewContainer(new Dictionary<string, Transform>());
	}

	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
	{
		return context.CreateCollector(GameMatcher.NewFloorCommand);
	}

	protected override bool Filter(GameEntity entity)
	{
		return entity.hasFloor && entity.hasNewFloorCommand;
	}

	protected override void Execute(System.Collections.Generic.List<GameEntity> entities)
	{
		foreach (var e in entities)
		{

			for (int i = 0; i < e.newFloorCommand.length; i++)
			{
				int randomTileIndex = WALLS.RandomIndex();
				var wallChoice = WALLS[randomTileIndex];
				var wall = _context.CreateEntity();
				wall.AddResource(wallChoice);
				wall.AddFloor("Floor-" + wallChoice.GetHashCode());
				wall.AddNestedView("Walls");
				wall.AddPosition(
					e.newFloorCommand.position.x,
					e.newFloorCommand.position.y
				);
				wall.isControllable = false;
			}

		}
	}
}
