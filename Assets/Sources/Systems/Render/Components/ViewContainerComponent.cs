using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game, Unique]
public sealed class ViewContainerComponent : IComponent
{

	public Transform value;

}
