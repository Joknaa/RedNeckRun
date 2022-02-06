using System;
using Player;
using Player.Characters;
using UnityEngine;

public class ExperienceController : MonoBehaviour {
    private int ExpGain = 10;
    private int ExpPoints = 0;
    private int ExpLevel = 0;
    private UIController _uiController;
    private SkinsController _skinsController;

    private void Start() {
        _uiController = GameObject.FindGameObjectWithTag("Manager").GetComponent<UIController>();
        _skinsController = GameObject.FindGameObjectWithTag("Manager").GetComponent<SkinsController>();
    }

    public void CollectedHorseshoe(ICharacters selectedCharacter) {
        int sign = selectedCharacter.UpdateExperience("Horseshoe");
        ExpPoints += sign * ExpGain;
        UpdateExpLevel(selectedCharacter);
    }
    
    public void CollectedCoffee(ICharacters selectedCharacter) {
        int sign = selectedCharacter.UpdateExperience("Coffee");
        ExpPoints += sign * ExpGain;
        UpdateExpLevel(selectedCharacter);
    }

    private void UpdateExpLevel(ICharacters selectedCharacter) {
        _uiController.UpdatePlayerScoreUI(ExpPoints);
        if (ExpPoints >= 100) {
            ExpLevel++;
            ExpPoints = 0;
            selectedCharacter.UpgradeSkin(_skinsController);
        } else if (ExpPoints < 0) {
            ExpLevel--;
            ExpPoints = 0;
            selectedCharacter.UpgradeSkin(_skinsController);
        }
        Debug.Log("Level: " + ExpLevel + "( " + ExpPoints + "/100 )");
    }
}