using Entitas;
using UnityEngine;

[Game]
public sealed class RestrictedAreaComponent : IComponent {
	public Vector2 TopLeft;
	public Vector2 BottomRight;
}