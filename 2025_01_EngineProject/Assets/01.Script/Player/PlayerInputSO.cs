using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _01.Script
{
    [CreateAssetMenu(fileName = "PlayerInputSO", menuName = "SO/PlayerInput")]
    public class PlayerInputSo : ScriptableObject, Controls.IPlayerActions
    {
        private Controls _controls;
        
        [SerializeField] public Vector2 moveDir;

        public event Action OnAttackPressed;

        public Vector2 mousePos;

        private void OnEnable()
        {
            if (_controls == null)
            {
                _controls = new Controls();
                _controls.Player.SetCallbacks(this);
            }
            _controls.Player.Enable();
        }

        private void OnDisable()
        {
            _controls.Player.Disable();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            moveDir = context.ReadValue<Vector2>();
        }

        public void OnAttack(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                OnAttackPressed?.Invoke();
            }
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            
        }
    }
}
