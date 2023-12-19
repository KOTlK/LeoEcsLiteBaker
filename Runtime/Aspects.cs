using Leopotam.EcsLite;

namespace LeoEcsLiteBaker.Runtime
{
    public class AspectBaker2<T1, T2> : EcsComponentBaker
    where T1 : struct
    where T2 : struct
    {
        public T1 FirstComponent;
        public T2 SecondComponent;
        
        protected override void BakeInternal(EcsWorld world, int entity)
        {
            var pool1 = world.GetPool<T1>();
            var pool2 = world.GetPool<T2>();

            ref var component1 = ref pool1.Add(entity);
            ref var component2 = ref pool2.Add(entity);

            component1 = FirstComponent;
            component2 = SecondComponent;
        }
    }
    
    public class AspectBaker3<T1, T2, T3> : EcsComponentBaker
        where T1 : struct
        where T2 : struct
        where T3 : struct
    {
        public T1 FirstComponent;
        public T2 SecondComponent;
        public T3 ThirdComponent;
        
        protected override void BakeInternal(EcsWorld world, int entity)
        {
            var pool1 = world.GetPool<T1>();
            var pool2 = world.GetPool<T2>();
            var pool3 = world.GetPool<T3>();

            ref var component1 = ref pool1.Add(entity);
            ref var component2 = ref pool2.Add(entity);
            ref var component3 = ref pool3.Add(entity);

            component1 = FirstComponent;
            component2 = SecondComponent;
            component3 = ThirdComponent;
        }
    }
    
    public class AspectBaker4<T1, T2, T3, T4> : EcsComponentBaker
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
    {
        public T1 FirstComponent;
        public T2 SecondComponent;
        public T3 ThirdComponent;
        public T4 FourthComponent;
        
        protected override void BakeInternal(EcsWorld world, int entity)
        {
            var pool1 = world.GetPool<T1>();
            var pool2 = world.GetPool<T2>();
            var pool3 = world.GetPool<T3>();
            var pool4 = world.GetPool<T4>();

            ref var component1 = ref pool1.Add(entity);
            ref var component2 = ref pool2.Add(entity);
            ref var component3 = ref pool3.Add(entity);
            ref var component4 = ref pool4.Add(entity);

            component1 = FirstComponent;
            component2 = SecondComponent;
            component3 = ThirdComponent;
            component4 = FourthComponent;
        }
    }
    
    public class AspectBaker5<T1, T2, T3, T4, T5> : EcsComponentBaker
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
    {
        public T1 FirstComponent;
        public T2 SecondComponent;
        public T3 ThirdComponent;
        public T4 FourthComponent;
        public T5 FifthComponent;
        
        protected override void BakeInternal(EcsWorld world, int entity)
        {
            var pool1 = world.GetPool<T1>();
            var pool2 = world.GetPool<T2>();
            var pool3 = world.GetPool<T3>();
            var pool4 = world.GetPool<T4>();
            var pool5 = world.GetPool<T5>();

            ref var component1 = ref pool1.Add(entity);
            ref var component2 = ref pool2.Add(entity);
            ref var component3 = ref pool3.Add(entity);
            ref var component4 = ref pool4.Add(entity);
            ref var component5 = ref pool5.Add(entity);

            component1 = FirstComponent;
            component2 = SecondComponent;
            component3 = ThirdComponent;
            component4 = FourthComponent;
            component5 = FifthComponent;
        }
    }
    
    public class AspectBaker6<T1, T2, T3, T4, T5, T6> : EcsComponentBaker
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
    {
        public T1 FirstComponent;
        public T2 SecondComponent;
        public T3 ThirdComponent;
        public T4 FourthComponent;
        public T5 FifthComponent;
        public T6 SixthComponent;
        
        protected override void BakeInternal(EcsWorld world, int entity)
        {
            var pool1 = world.GetPool<T1>();
            var pool2 = world.GetPool<T2>();
            var pool3 = world.GetPool<T3>();
            var pool4 = world.GetPool<T4>();
            var pool5 = world.GetPool<T5>();
            var pool6 = world.GetPool<T6>();

            ref var component1 = ref pool1.Add(entity);
            ref var component2 = ref pool2.Add(entity);
            ref var component3 = ref pool3.Add(entity);
            ref var component4 = ref pool4.Add(entity);
            ref var component5 = ref pool5.Add(entity);
            ref var component6 = ref pool6.Add(entity);

            component1 = FirstComponent;
            component2 = SecondComponent;
            component3 = ThirdComponent;
            component4 = FourthComponent;
            component5 = FifthComponent;
            component6 = SixthComponent;
        }
    }
    
    public class AspectBaker7<T1, T2, T3, T4, T5, T6, T7> : EcsComponentBaker
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
    {
        public T1 FirstComponent;
        public T2 SecondComponent;
        public T3 ThirdComponent;
        public T4 FourthComponent;
        public T5 FifthComponent;
        public T6 SixthComponent;
        public T7 SeventhComponent;
        
        protected override void BakeInternal(EcsWorld world, int entity)
        {
            var pool1 = world.GetPool<T1>();
            var pool2 = world.GetPool<T2>();
            var pool3 = world.GetPool<T3>();
            var pool4 = world.GetPool<T4>();
            var pool5 = world.GetPool<T5>();
            var pool6 = world.GetPool<T6>();
            var pool7 = world.GetPool<T7>();

            ref var component1 = ref pool1.Add(entity);
            ref var component2 = ref pool2.Add(entity);
            ref var component3 = ref pool3.Add(entity);
            ref var component4 = ref pool4.Add(entity);
            ref var component5 = ref pool5.Add(entity);
            ref var component6 = ref pool6.Add(entity);
            ref var component7 = ref pool7.Add(entity);

            component1 = FirstComponent;
            component2 = SecondComponent;
            component3 = ThirdComponent;
            component4 = FourthComponent;
            component5 = FifthComponent;
            component6 = SixthComponent;
            component7 = SeventhComponent;
        }
    }
    
    public class AspectBaker8<T1, T2, T3, T4, T5, T6, T7, T8> : EcsComponentBaker
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
    {
        public T1 FirstComponent;
        public T2 SecondComponent;
        public T3 ThirdComponent;
        public T4 FourthComponent;
        public T5 FifthComponent;
        public T6 SixthComponent;
        public T7 SeventhComponent;
        public T8 EighthComponent;
        
        protected override void BakeInternal(EcsWorld world, int entity)
        {
            var pool1 = world.GetPool<T1>();
            var pool2 = world.GetPool<T2>();
            var pool3 = world.GetPool<T3>();
            var pool4 = world.GetPool<T4>();
            var pool5 = world.GetPool<T5>();
            var pool6 = world.GetPool<T6>();
            var pool7 = world.GetPool<T7>();
            var pool8 = world.GetPool<T8>();

            ref var component1 = ref pool1.Add(entity);
            ref var component2 = ref pool2.Add(entity);
            ref var component3 = ref pool3.Add(entity);
            ref var component4 = ref pool4.Add(entity);
            ref var component5 = ref pool5.Add(entity);
            ref var component6 = ref pool6.Add(entity);
            ref var component7 = ref pool7.Add(entity);
            ref var component8 = ref pool8.Add(entity);

            component1 = FirstComponent;
            component2 = SecondComponent;
            component3 = ThirdComponent;
            component4 = FourthComponent;
            component5 = FifthComponent;
            component6 = SixthComponent;
            component7 = SeventhComponent;
            component8 = EighthComponent;
        }
    }
}