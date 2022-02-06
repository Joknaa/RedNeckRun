namespace Player.Characters {
    public interface ICharacters {

        int UpdateExperience(string interactable);
        void UpgradeSkin(SkinsController _skinsController);
        
    }
}