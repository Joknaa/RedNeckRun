using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {
    private Rigidbody _rigidbody;
    private Vector2 startTouchPosition, endTouchPosition;

    [SerializeField] private int moveSpeed;
    [SerializeField] private int sidewaysMove;

    void Start() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update() {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        SwipeHorizontally();
    }

    private void SwipeHorizontally() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {
            endTouchPosition = Input.GetTouch(0).position;

            Vector3 currentPosition = transform.position;
            if ((endTouchPosition.x < startTouchPosition.x))
                transform.position = new Vector3(currentPosition.x - sidewaysMove, currentPosition.y, currentPosition.z);
            if ((endTouchPosition.x > startTouchPosition.x))
                transform.position = new Vector3(currentPosition.x + sidewaysMove, currentPosition.y, currentPosition.z);
            
        }
    }
}