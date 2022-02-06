using System;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {
    [SerializeField] private List<Sprite> barSprites;
    private GameObject text_playerScore;

    private void Start() {
        text_playerScore = GameObject.FindGameObjectWithTag("Player_Bar");
    }

    public void UpdatePlayerScoreUI(int currentExp) {
        text_playerScore.GetComponent<SpriteRenderer>().sprite = barSprites[currentExp / 10];
    }
}