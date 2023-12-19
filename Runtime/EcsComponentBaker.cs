﻿using Leopotam.EcsLite;
using UnityEngine;

namespace LeoEcsLiteBaker.Runtime
{
    public abstract class EcsComponentBaker : MonoBehaviour
    {
        public void Bake(EcsWorld world, int entity)
        {
            BakeInternal(world, entity);
            Destroy(this);
        }
        protected abstract void BakeInternal(EcsWorld world, int entity);
    }
}