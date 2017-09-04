using System.Collections.Generic;
using Entitas;

public sealed class CoroutineSystem : ReactiveSystem<GameEntity> {

	public CoroutineSystem(Contexts contexts) : base(contexts.game) {
		UnityEngine.Debug.Log("Coroutine System creating...");
	}


	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
		return context.CreateCollector(GameMatcher.Coroutine);
	}

	protected override bool Filter(GameEntity entity) {
		return entity.hasCoroutine;
	}

	protected override void Execute(List<GameEntity> entities) {
		foreach (var e in entities) {
			var coroutine = e.coroutine.value;
			if (coroutine.MoveNext())
				continue;
			e.RemoveCoroutine();
			e.Destroy();
		}
	}

}
