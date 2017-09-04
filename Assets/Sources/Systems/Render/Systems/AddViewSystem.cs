using Entitas;
using Entitas.Unity;
using UnityEngine;
using System.Collections.Generic;

public sealed class AddViewSystem : ReactiveSystem<GameEntity>, IInitializeSystem {
	private readonly GameContext _context;

	public AddViewSystem(Contexts contexts) : base(contexts.game) {
		_context = contexts.game;
	}


	public void Initialize() {
		_context.SetViewContainer(new GameObject("Views").transform);
		_context.SetNestedViewContainer(new Dictionary<string, Transform>());
	}


	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
		return context.CreateCollector(GameMatcher.Resource);
	}

	protected override bool Filter(GameEntity entity) {
		return true;
	}

	protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
		var viewContainer = _context.viewContainer.value;
		var nestedViewContainer = _context.nestedViewContainer.value;

		foreach (var e in entities) {
			string resName = "Prefabs/" + e.resource.name;
			GameObject res = Resources.Load<GameObject>(resName) as GameObject;
			GameObject gameObject = null;

			try {
				gameObject = UnityEngine.Object.Instantiate(res);
			}
			catch (System.Exception) {
				Debug.Log("Cannot Instantiatte " + resName);
			}

			if (gameObject == null) {
				continue;
			}

			Transform parent = e.hasNestedView ? GetNested(e.nestedView.name, viewContainer, nestedViewContainer) : viewContainer;
			gameObject.transform.SetParent(parent, false);
			e.AddView(gameObject);
			gameObject.Link(e, _context);

			if (e.hasPosition) {
				PositionComponent pos = e.position;
				gameObject.transform.position = new Vector3(pos.x, pos.y);
			}
		}
	}


	Transform GetNested(string name,
		Transform viewContainer,
		IDictionary<string, Transform> nestedViewContainer) {
		if (nestedViewContainer.ContainsKey(name)) {
			return nestedViewContainer[name];
		}

		Transform nestedView = new GameObject(name).transform;
		nestedView.SetParent(viewContainer, false);
		nestedViewContainer[name] = nestedView;
		return nestedView;
	}
}