using LeoEcsLiteBaker.Samples.Components;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;
using UnityEngine;

namespace LeoEcsLiteBaker.Samples.Systems
{
    public class MoveSystem : IEcsRunSystem
    {
        private readonly EcsFilterInject<Inc<Point, PointView>> _filter = default;
        private readonly EcsPoolInject<Point> _points = default;
        private readonly EcsPoolInject<PointView> _views = default;
        
        public void Run(IEcsSystems systems)
        {
            foreach (var entity in _filter.Value)
            {
                ref var point = ref _points.Value.Get(entity);
                ref var view = ref _views.Value.Get(entity);

                view.Transform.position += point.Direction * point.Speed * Time.deltaTime;
            }
        }
    }
}