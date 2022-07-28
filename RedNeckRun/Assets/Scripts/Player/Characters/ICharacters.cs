namespace Player.Characters {
    public interface ICharacters {

        int UpdateExperience(string interactable);
        void ChangeSkin(SkinsController _skinsController);
        
    }
}