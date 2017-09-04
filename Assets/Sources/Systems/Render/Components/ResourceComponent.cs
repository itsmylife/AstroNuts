using Entitas;

[Game]
public sealed class ResourceComponent : IComponent
{
	public Prefab prefab;

	public string name
	{
		get { return prefab.ToString(); }
	}
}