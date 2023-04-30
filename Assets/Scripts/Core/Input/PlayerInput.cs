using ElectrumGames.Core.Configs;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ElectrumGames.Core.Input
{
    public class PlayerInput : IInput, InputSchema.IPlayerActions
    {
        private InputSchema _inputSchema;
        
        public float VerticalDirection { get; private set; }
        public float HorizontalDirection { get; private set; }

        private bool _isMovementUpdated;

        public PlayerInput(InputSchema inputSchema)
        {
            _inputSchema = inputSchema;
        }
        
        public void Init()
        {
            _inputSchema.Player.SetCallbacks(this);
            _inputSchema.Enable();
        }

        public void Update(float deltaTime)
        {
            if (!_isMovementUpdated)
            {
                HorizontalDirection = 0f;
                VerticalDirection = 0f;
                return;
            }

            var inputData = _inputSchema.Player.Movement.ReadValue<Vector2>();
            HorizontalDirection = inputData.x;
            VerticalDirection = inputData.y;
        }

        public void OnMovement(InputAction.CallbackContext context)
        {
            _isMovementUpdated = context.phase != InputActionPhase.Canceled;
            Debug.Log(_isMovementUpdated);
        }
    }
}