using Leopotam.EcsLite;
using UnityEngine;

namespace LeoEcsLiteBaker.Runtime
{
    public static class EcsSystemsExtensions
    {
        public static IEcsSystems BakeScene(this IEcsSystems systems)
        {
            var world = systems.GetWorld();

            var bakers = Object.FindObjectsByType<EntityBaker>(FindObjectsSortMode.None);

            foreach (var baker in bakers)
            {
                baker.Bake(world);
            }

            return systems;
        }
    }
}