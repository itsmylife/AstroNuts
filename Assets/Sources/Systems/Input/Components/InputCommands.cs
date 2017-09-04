// AstroNut Movement Commands
//[Game]
//public sealed class JumpCommand : ICommand
//{
//	public Jump type;
//}
//
//[Game]
//public sealed class DirectionCommand : ICommand
//{
//	public Direction direction;
//}



// Floor
[Game]
public sealed class NewFloorCommand : ICommand
{
	public int length;
	public UnityEngine.Vector3 position;
}



