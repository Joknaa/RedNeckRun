using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {
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
        if (touch.phase == TouchPhase.Began) {
            lastPosition = touch.position;
        }
        
        if (touch.phase == TouchPhase.Moved) {
            
            Vector3 direction = touch.position - lastPosition;
            Debug.Log(direction);
            var signedDirection = Mathf.Sign(direction.x);
            transform.Translate(Vector3.right * signedDirection * sidewaysMove * Time.deltaTime);
            // _rigidbody.AddForce(sidewaysMove * signedDirection * Time.deltaTime, 0, 0);
            lastPosition = touch.position;
            
            /*
            endTouchPosition = touch.position;

                Vector3 currentPosition = transform.position;
                float swipeDistance = endTouchPosition.x - lastPosition.x;
                float slideDistance = swipeDistance * Time.deltaTime * 0.01f;

                Debug.Log(slideDistance);
                if ((swipeDistance > 0))
                    transform.position =
                        new Vector3(currentPosition.x + slideDistance, currentPosition.y, currentPosition.z);
                if ((swipeDistance < 0))
                    transform.position =
                        new Vector3(currentPosition.x + slideDistance, currentPosition.y, currentPosition.z);
                        */
                
        }
    }
}