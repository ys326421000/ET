﻿using UnityEngine;

namespace ET
{
    public class ChangePosition_SyncGameObjectPos: AEvent<EventType.ChangePosition>
    {
        protected override void Run(EventType.ChangePosition args)
        {
            GameObjectComponent gameObjectComponent = args.Unit.GetComponent<GameObjectComponent>();
            if (gameObjectComponent == null)
            {
                return;
            }
            Transform transform = gameObjectComponent.GameObject.transform;
            transform.position = args.Unit.Position;
        }
    }
}