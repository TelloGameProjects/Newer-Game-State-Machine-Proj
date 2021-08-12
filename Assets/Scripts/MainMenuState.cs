using System;
using Vast.StateMachine;



[Serializable]
public class MainMenuState : State 
{
    public MainMenuState()
    {
        Name = "MainMenuState";
    }

    #region Class Methods
    public override void OnEnter() { }
    public override void OnExit() { }
    public override void Update() { }
    public override void FixedUpdate() { }
    #endregion
}
