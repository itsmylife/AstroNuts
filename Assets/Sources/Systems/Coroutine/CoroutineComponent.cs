using Entitas;
using System.Collections;

[Game]
public sealed class CoroutineComponent : IComponent
{
	public IEnumerator value;
}
