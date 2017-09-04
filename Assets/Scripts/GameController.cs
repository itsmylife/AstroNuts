using UnityEngine;
using Entitas;
using Entitas.VisualDebugging.Unity;


public class GameController : MonoBehaviour {
	private Systems _allSystems;


	void Start() {
		var contexts = Contexts.sharedInstance;

		_allSystems = CreateSystems(contexts);
		_allSystems.Initialize();
	}


	void Update() {
		_allSystems.Execute();
		_allSystems.Cleanup();
	}


	void OnDestroy() {
		_allSystems.TearDown();
	}


	Systems CreateSystems(Contexts contexts) {
		Systems systems;

//#if (UNITY_EDITOR)
		systems = new DebugSystems("Debug Systems");
//#else
		//sys = new Feature("Systems");
//#endif

		systems
			.Add(new CoroutineSystem(contexts))
			.Add(new RenderFeature(contexts))
			.Add(new MovementFeature(contexts))
			.Add(new GameStartSystem(contexts))
			.Add(new AstroNutSystems(contexts))
			.Add(new FloorSystems(contexts))
			.Add(new GameCreateSystem(contexts));


		return systems;
	}
}