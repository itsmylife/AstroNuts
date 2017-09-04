using Entitas;

public sealed class GameStartSystem : IInitializeSystem
{
	private readonly GameContext _context;

	public GameStartSystem(Contexts contexts)
	{
		_context = contexts.game;
	}

	public void Initialize()
	{
		UnityEngine.Debug.Log("Game Start System creating...");
		_context.SetConfig(
			DefaultConfigConstants.LIVES,
			DefaultConfigConstants.FUEL
		);
	}
}