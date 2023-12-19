using System;
using UnityEngine;

namespace LeoEcsLiteBaker.Samples.Components
{
    [Serializable]
    public struct Point
    {
        public float Speed;
        public Vector3 Direction;
    }
}