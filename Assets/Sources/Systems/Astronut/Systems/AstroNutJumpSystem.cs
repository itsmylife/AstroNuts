using System.Collections.Generic;
using Entitas;
using UnityEngine;

public sealed class AstroNutJumpSystem : ReactiveSystem<GameEntity>
{
	//private readonly GameContext _context;


	public AstroNutJumpSystem(Contexts contexts) : base(contexts.game)
	{
		//_context = contexts.game;
	}


	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
	{
		return context.CreateCollector(GameMatcher.Astronut);
	}

	protected override bool Filter(GameEntity entity)
	{
		// TODO write an extension for isAstronut!
		return entity.hasAstronut /*&& entity.hasJumpCommand*/;
	}

	protected override void Execute(List<GameEntity> entities)
	{
		foreach (var e in entities)
		{
			Debug.Log("Movement: "/* + e.jumpCommand.type*/);
		}
	}
}