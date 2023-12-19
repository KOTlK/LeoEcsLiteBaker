using Leopotam.EcsLite;

namespace LeoEcsLiteBaker.Runtime
{
    public class EcsComponent<T> : EcsComponentBaker
    where T : struct
    {
        public T Origin;
        
        protected override void BakeInternal(EcsWorld world, int entity)
        {
            var pool = world.GetPool<T>();
            ref var component = ref pool.Add(entity);
            component = Origin;
        }
    }
}