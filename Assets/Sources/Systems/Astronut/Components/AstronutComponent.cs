using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Unique]
public sealed class AstronutComponent : IComponent
{
	public string name;
}
