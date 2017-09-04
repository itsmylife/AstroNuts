using Entitas;

public sealed class GameCreateSystem : IInitializeSystem {
	private readonly Contexts _contexts;


	public GameCreateSystem(Contexts contexts) {
		_contexts = contexts;
	}

	public void Initialize() {
		CreateRandomWalls();

		GameEntity astronut = _contexts.game.CreateEntity();
		astronut.AddResource(Prefab.AstroNut);
		astronut.AddAstronut("AstroNut");
		astronut.AddPosition(0, -3f);
		astronut.AddMovement(Direction.RIGHT);
		// FIXME Add restriction
		astronut.isControllable = true;
	}


	private void CreateRandomWalls() {
		// TODO for now it is ok. Later think better solution for floor 
		GameEntity wall = _contexts.game.CreateEntity();
		wall.AddFloor("Floor-" + wall.GetHashCode());
		/* TODO maybe we can use 
		 * 
		 * Position.LEFT
		 * Position.RIGHT
		 * Position.FULL
		 * 
		 * so it would appear 4 units length and 
		 * positioned as we sended before (lets say left)
		 * 
		 * 
		 * 
		 */
		wall.AddNewFloorCommand(4, new UnityEngine.Vector3(1f, 1f));
	}
}