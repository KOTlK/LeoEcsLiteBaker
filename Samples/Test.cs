using LeoEcsLiteBaker.Runtime;
using LeoEcsLiteBaker.Samples.Systems;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;
using UnityEngine;

namespace LeoEcsLiteBaker.Samples
{
    public class Test : MonoBehaviour
    {
        private EcsSystems _systems;

        private void Start()
        {
            var world = new EcsWorld();

            _systems = new EcsSystems(world);
            
            _systems
                .Add(new MoveSystem())
                .Inject()
                .BakeScene()
                .Init();
        }

        private void Update()
        {
            _systems.Run();
        }
    }
}