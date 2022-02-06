using System.Collections.Generic;

namespace Player.Characters {
    public class Redneck : ICharacters {
        private readonly List<string> allowedCollectibles = new List<string>() {
            "Horseshoe"
        };
        
        public int UpdateExperience(string interactable) {
            return allowedCollectibles.Contains(interactable) ? 1 : -1;

        }

        public void UpgradeSkin(SkinsController _skinsController) {
            _skinsController.SetRedneckSkin();

        }
    }
}