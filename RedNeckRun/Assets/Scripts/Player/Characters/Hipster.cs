using System.Collections.Generic;

namespace Player.Characters {
    public class Hipster : ICharacters{
        private readonly List<string> allowedCollectibles = new List<string>() {
            "Coffee"
        };

        public int UpdateExperience(string interactable) {
            return allowedCollectibles.Contains(interactable) ? 1 : -1;
        }

        public void ChangeSkin(SkinsController _skinsController) {
            _skinsController.SetHipsterSkin();
        }
    }
}