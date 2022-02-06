using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    private GameObject playerCharacter;
    [SerializeField] private Vector3 positionOffSet;
    [SerializeField] private float cameraSpeed;
    void Start() {
        playerCharacter = GameObject.FindGameObjectWithTag("Player");
    }


    void Update() {
        Vector3 position = transform.position;
        Vector3 playerPosition = playerCharacter.transform.position;
        Vector3 intendedPosition = new Vector3(playerPosition.x + positionOffSet.x, playerPosition.y + positionOffSet.y, playerPosition.z + positionOffSet.z);

        transform.position = Vector3.Lerp(position, intendedPosition, cameraSpeed * Time.deltaTime); 
        
    }
}