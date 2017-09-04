using Entitas;

public sealed class MovementSystem : IExecuteSystem {
	private readonly GameContext _context;
	private readonly IGroup<GameEntity> _entities;

	public MovementSystem(Contexts contexts) {
		_context = contexts.game;
		_entities = _context.GetGroup(GameMatcher.Movement);
		// TODO if a new entity added, is it going to work?
	}

	public void Execute() {
		foreach (var e in _entities.GetEntities()) {
			e.ReplacePosition(e.position.x + 0.01f, e.position.y);
		}
	}

}