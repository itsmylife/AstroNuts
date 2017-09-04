using Entitas;

public sealed class AstroNutSystems : Feature
{
	public AstroNutSystems(Contexts contexts) : base("AstroNut Systems")
	{
		Add(new AstroNutJumpSystem(contexts));
		//Add(new AstroNutDirectionSystem(contexts));
	}
}