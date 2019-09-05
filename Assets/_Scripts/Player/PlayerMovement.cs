using UnityEngine;

namespace Reynold.Medieval
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private bool enableInput = true;
        [Header("Movement Properties")]
        [SerializeField] private float baseSpeed = 2f;
        [SerializeField] private float lookAtSpeed = 0.8f;
        [SerializeField] private float gravityMultiplier = 1f;
        
        [Header("Damp Properties")]
        [SerializeField] private float velocityDampGround = 0.1f;
        [SerializeField] private float velocityDampAir = 0.7f;

        [Header("Sprint Properties")]
        [SerializeField] private bool enableSprint = true;
        [SerializeField] private float sprintSpeed = 3f;

        private MyInputAction input;
        private CharacterController cc;
        private Camera mainCam;
        private Vector3 moveDir;
        private Vector2 moveVector;
        private float targetSpeed;
        private Vector3 lastMovement;
        private float lastRot;
        private Vector3 gravityVector;
        private Vector3 currentVelocity = Vector3.zero;
        private Vector3 currentVelocityLerp = Vector3.zero;
        private bool isSprint = false;

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
            cc = GetComponent<CharacterController>();
            mainCam = Camera.main;
        }

        private void Update()
        {
            if (!cc.enabled)
                return;
 
            transform.rotation = Quaternion.AngleAxis(PollRotation(), Vector3.up);
            
            bool isGrounded = cc.isGrounded;
            if (isGrounded)
                gravityVector.y = 0f;
            
            UpdateMovement();
        }

        private Vector2 PollMovement()
        {
            Vector3 target = !this.enableInput ? Vector3.zero : this.GetMovementRelativeToCamera(input.Player.Movement.ReadValue<Vector2>());
            this.lastMovement = target;
            return new Vector2(this.lastMovement.x, this.lastMovement.z);
        }
        
        private float PollRotation()
        {
            if (this.lastMovement.sqrMagnitude < 0.001f)
                return this.lastRot;
            this.lastRot = Quaternion.Lerp(Quaternion.LookRotation(this.transform.forward), Quaternion.LookRotation(this.lastMovement), Time.deltaTime * 14f * this.lookAtSpeed).eulerAngles.y;
            return this.lastRot;
        }

        private void UpdateMovement()
        {
            Vector2 movement = PollMovement();
            this.moveDir = new Vector3(movement.x, 0f, movement.y);
            movement.Normalize();
            moveDir.Normalize();
            float speed = baseSpeed;
            if (isSprint && enableSprint)
                speed = sprintSpeed;
            this.targetSpeed = Mathf.Lerp(0.0f, speed, movement.sqrMagnitude);
            
            if (cc.isGrounded && Physics.Raycast(transform.position, -Vector3.up, cc.stepOffset * 2f))
                gravityVector.y = -Mathf.Abs(Physics.gravity.y);
            else
                ApplyGravity();
            currentVelocity = Vector3.SmoothDamp(currentVelocity, moveDir * targetSpeed, ref currentVelocityLerp, !cc.isGrounded ? velocityDampAir : velocityDampGround);
            cc.Move((gravityVector + currentVelocity) * Time.deltaTime);
        }
        
        private void ApplyGravity()
        {
            gravityVector += Time.fixedDeltaTime * Mathf.Abs(Physics.gravity.y) * gravityMultiplier * Vector3.down;
        }

        private Vector3 GetMovementRelativeToCamera(Vector2 movement)
        {
            Vector3 forward = this.mainCam.transform.forward;
            forward.y = 0.0f;
            forward.Normalize();
            
            Vector3 right = this.mainCam.transform.right;
            right.y = 0.0f;
            right.Normalize();
            
            return right * movement.x + forward * movement.y;
        }
    }
}