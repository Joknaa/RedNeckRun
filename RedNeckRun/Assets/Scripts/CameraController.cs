using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    private GameObject playerCharacter;
    [SerializeField] private float distanceFromPlayer;
    void Start() {
        playerCharacter = GameObject.FindGameObjectWithTag("Player");
    }


    void Update() {
        Vector3 position = transform.position;
        
        transform.position = new Vector3(position.x, position.y, playerCharacter.transform.position.z - distanceFromPlayer);
    }
}