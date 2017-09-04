using Entitas;
using Entitas.Unity;
using UnityEngine;

public class RemoveViewSystem : ReactiveSystem<GameEntity> {
	public RemoveViewSystem(Contexts contexts) : base(contexts.game) {
	}

	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
		return context.CreateCollector(GameMatcher.Destroyed);
	}

	protected override bool Filter(GameEntity entity) {
		return entity.isDestroyed;
	}

	protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
		foreach (var e in entities) {
			UnityEngine.Debug.Log("Remove View System::Execute -> entity has view? " + e.hasView);

			destroyView(e.view);
			e.RemoveView();
		}
	}

	private void destroyView(ViewComponent viewComponent) {
		GameObject gameObject = viewComponent.gameObject;
		// TODO maybe we should add a tween here
		gameObject.Unlink();
		Object.Destroy(gameObject);
	}
}