using Entitas.CodeGeneration.Attributes;
using Entitas;


[Game, Unique]
public sealed class ConfigComponent : IComponent
{
	public int lives;
	public int fuel;
}