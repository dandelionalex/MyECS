using Unity.Entities;
using Unity.Mathematics;

namespace Dandelion.ECS
{
    public struct InputComponent : IComponentData
    {
        public float2 Movement;
    }
}

