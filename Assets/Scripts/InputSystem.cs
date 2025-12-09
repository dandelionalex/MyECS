using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Dandelion.ECS
{
    public partial class InputSystem : SystemBase
    {
        private Controls _controls;

        protected override void OnCreate ()
        {
            if(!SystemAPI.TryGetSingleton<InputComponent>(out InputComponent input))
            {
                EntityManager.CreateEntity(typeof(InputComponent));
                // also InputConponent can be created usig Baker in Player authoring
            }

            _controls = new Controls();
            _controls.Enable();
        }

        protected override void OnUpdate ()
        {
            float2 move = (float2)_controls.Player.Move.ReadValue<Vector2>();
            SystemAPI.SetSingleton(new InputComponent {movement = move});
        }
    }
}