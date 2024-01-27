namespace Weapons.Weapon
{
    public interface IAssemblyCycleView
    {
        void DisplayNextAnimation();
        void DisplayText(string text);
        void DisplayContinueButton();
        void DisplayEndButton();
    }
}