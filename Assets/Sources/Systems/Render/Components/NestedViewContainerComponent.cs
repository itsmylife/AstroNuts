using Entitas;
using UnityEngine;
using System.Collections.Generic;
using Entitas.CodeGeneration.Attributes;

[Unique]
public sealed class NestedViewContainerComponent : IComponent
{
	public IDictionary<string, Transform> value;
}
