using Player.Characters;
using UnityEngine;

namespace Player {
    public class MovementController : MonoBehaviour {
        private Rigidbody _rigidbody;
        private Vector2 lastPosition, endTouchPosition;

        [SerializeField] private int moveSpeed;
        [SerializeField] private int sidewaysMove;

        private void Start() {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update() {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            SwipeHorizontally();
        }

        private void SwipeHorizontally() {
            if (Input.touchCount <= 0) return;
        
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) 
                lastPosition = touch.position;

            if (touch.phase == TouchPhase.Moved) {
                Vector3 direction = touch.position - lastPosition;
                var signedDirection = Mathf.Sign(direction.x);
                transform.Translate(Vector3.right * signedDirection * sidewaysMove * Time.deltaTime);
                lastPosition = touch.position;
            }
        }

        public void RotatePlayer() {
            //transform.Rotate(0 ,300, 0);
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, new Vector3(0, 360, 0), Time.deltaTime);
            transform.RotateAround(transform.position, transform.up, 0);
            Debug.Log("Rotated");
        }
    }
}