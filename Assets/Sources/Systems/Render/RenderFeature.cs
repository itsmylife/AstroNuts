public class RenderFeature : Feature {
	public RenderFeature(Contexts contexts) : base("Render Systems") {
		Add(new AddViewSystem(contexts));
		Add(new RemoveViewSystem(contexts));
		Add(new RenderPositionSystem(contexts));
	}
}