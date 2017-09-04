using Entitas;

public class RestrictionControllerSystem : IExecuteSystem {
	private readonly GameContext _context;
	private readonly IGroup<GameEntity> _entities;

	public RestrictionControllerSystem(Contexts contexts) {
		_context = contexts.game;
		_entities = _context.GetGroup(GameMatcher.Movement);
		// TODO if a new entity added, is it going to work?
	}
	
	public void Execute() {
		foreach (var e in _entities.GetEntities()) {
			// FIXME check the restriction
		}
	}
}