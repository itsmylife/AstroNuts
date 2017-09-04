using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
	
	private Direction direction = Direction.LEFT;

	void Start()
	{
	//	context = Contexts.sharedInstance.game;
	}
	
	public void Jump()
	{

	//	context.CreateEntity().AddComponent(GameComponentsLookup.Astronut, new AstronutComponent());
	//	context.astronutEntity.AddMoveInput(Movement.Jump);
	}


	public void ChangeDirection()
	{
		direction = direction == Direction.LEFT ? Direction.RIGHT : Direction.LEFT;
		//context.astronutEntity.AddMoveInput(direction);
	}
}
