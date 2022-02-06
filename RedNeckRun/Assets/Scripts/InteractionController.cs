using System;
using Player;
using Player.Characters;
using UnityEngine;

public class InteractionController : MonoBehaviour {
    private const string GATE_HIPSTER_TAG = "Gate_Hipster";
    private const string GATE_REDNECK_TAG = "Gate_Redneck";
    private const string COLLECTABLE_COFFEE_TAG = "Collectable_Coffee";
    private const string COLLECTABLE_HORSESHOE_TAG = "Collectable_Horseshoe";
    private ExperienceController _experienceController;
    private SkinsController _skinsController;
    private ICharacters selectedCharacter { get; set; }

    private void Start() {
        _experienceController = GameObject.FindGameObjectWithTag("Manager").GetComponent<ExperienceController>();
        _skinsController = GameObject.FindGameObjectWithTag("Player").GetComponent<SkinsController>();
    }

    private void OnTriggerEnter(Collider other) {
        switch (other.tag) {
            case GATE_HIPSTER_TAG:
                selectedCharacter = new Hipster();
                selectedCharacter.UpgradeSkin(_skinsController);
                break;
            case GATE_REDNECK_TAG:
                selectedCharacter = new Redneck();
                selectedCharacter.UpgradeSkin(_skinsController);
                break;
            case COLLECTABLE_COFFEE_TAG:
                _experienceController.CollectedCoffee(selectedCharacter);
                break;
            case COLLECTABLE_HORSESHOE_TAG:
                _experienceController.CollectedHorseshoe(selectedCharacter);
                break;
        }

        //_movementController.RotatePlayer();
        other.gameObject.SetActive(false);
    }
}