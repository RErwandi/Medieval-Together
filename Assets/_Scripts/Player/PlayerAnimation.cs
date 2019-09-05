using UnityEngine;

namespace Reynold.Medieval
{
    public class PlayerAnimation : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        private MyInputAction input;
        private float forwardSpeed;
        private bool isSprint = false;
        private static readonly int Speed = Animator.StringToHash("Speed");
        private static readonly int Sprint = Animator.StringToHash("Sprint");
        private const float GroundAcceleration = 10f;
        private const float GroundDeceleration = 5f;
        private bool IsMoveInput => !Mathf.Approximately(input.Player.Movement.ReadValue<Vector2>().sqrMagnitude, 0f);

        private void OnEnable()
        {
            input.Player.Sprint.performed += ctx => isSprint = true;
            input.Player.Sprint.canceled += ctx => isSprint = false;
            input.Enable();
        }

        private void OnDisable()
        {
            input.Disable();
        }
        
        private void Awake()
        {
            input = new MyInputAction();
            if(animator == null)
                animator = GetComponent<Animator>();
        }

        private void Update()
        {
            // Cache the move input and cap it's magnitude at 1.
            var moveInput = input.Player.Movement.ReadValue<Vector2>();
            if (moveInput.sqrMagnitude > 1f)
                moveInput.Normalize();

            // Calculate the speed intended by input.
            var desiredForwardSpeed = moveInput.magnitude;

            // Determine change to speed based on whether there is currently any move input.
            var acceleration = IsMoveInput ? GroundAcceleration : GroundDeceleration;

            // Adjust the forward speed towards the desired speed.
            forwardSpeed = Mathf.MoveTowards(forwardSpeed, desiredForwardSpeed, acceleration * Time.deltaTime);

            // Set the animator parameter to control what animation is being played.
            animator.SetFloat(Speed, forwardSpeed);
            animator.SetBool(Sprint, isSprint);
            //animator.SetFloat("SpeedMultiplier", controller.Sprint ? 1.5f : 1f);
            //animator.SetBool("IsGrounded", controller.CharacterController.isGrounded);
        }
    }
}