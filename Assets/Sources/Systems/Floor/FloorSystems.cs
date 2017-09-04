using Entitas;

public class FloorSystems : Feature
{
	public FloorSystems(Contexts contexts) : base("Floor Systems")
	{
		Add(new AddFloorSystem(contexts));
	}
}
