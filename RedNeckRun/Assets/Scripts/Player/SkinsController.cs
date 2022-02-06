using System;
using UnityEngine;

namespace Player {
    public class SkinsController : MonoBehaviour {
        [SerializeField] private GameObject character_hipster;
        [SerializeField] private GameObject character_redneck;
        [SerializeField] private GameObject character_initial;
        
        private void Start() {
            //character_initial = GameObject.FindGameObjectWithTag("Player_Initial");
            //character_hipster = GameObject.FindGameObjectWithTag("Player_Hipster");
            //character_redneck = GameObject.FindGameObjectWithTag("Player_Redneck");
        }
        
        public void SetHipsterSkin() {
            SetVisibility(false, true, false);
        }

        public void SetRedneckSkin() {
            SetVisibility(false, false, true);
        }

        public void SetInitialSkin() {
            SetVisibility(true, false, false);
        }

        private void SetVisibility(bool initial, bool hipster, bool redneck) {
            character_initial.SetActive(initial);
            character_hipster.SetActive(hipster);
            character_redneck.SetActive(redneck);
        }
    }
}