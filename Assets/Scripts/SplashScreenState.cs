using System;
using Vast.StateMachine;



[Serializable]
public class SplashScreenState : State 
{
    public SplashScreenState()
    {
        Name = "SplashScreenState";
    }

    #region Class Methods
    public override void OnEnter() 
    {
        // Load MainMenuScene
        // Unload All other scenes
    }
    public override void OnExit() 
    {
        // unload main menu scene
    }
    public override void Update() { }
    public override void FixedUpdate() { }
    #endregion
}
