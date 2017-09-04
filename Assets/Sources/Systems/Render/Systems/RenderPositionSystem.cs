﻿using System.Collections.Generic;
using Entitas;

public sealed class RenderPositionSystem : ReactiveSystem<GameEntity>
{

	public RenderPositionSystem(Contexts contexts) : base(contexts.game)
	{
	}


	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
	{
		return context.CreateCollector(GameMatcher.Position);
	}

	protected override bool Filter(GameEntity entity)
	{
		return entity.hasView && entity.hasPosition;
	}

	protected override void Execute(List<GameEntity> entities)
	{
		foreach (var e in entities)
		{
			var pos = e.position;
			e.view.gameObject.transform.position = new UnityEngine.Vector3(pos.x, pos.y);
		}
	}
}