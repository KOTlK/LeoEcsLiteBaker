using Leopotam.EcsLite;
using UnityEngine;

namespace LeoEcsLiteBaker.Runtime
{
    [DisallowMultipleComponent]
    public class EntityBaker : MonoBehaviour
    {
        [SerializeField] private bool _deleteAfterBake;
        [SerializeField] private bool _baked;
        
        public void Bake(EcsWorld world)
        {
            if (_baked)
                return;
            
            var entity = world.NewEntity();
            var components = gameObject.GetComponents<EcsComponentBaker>();

            foreach (var component in components)
            {
                component.Bake(world, entity);
            }
            
            _baked = true;

            if (_deleteAfterBake)
            {
                Destroy(gameObject);
            }
        }
    }
}
