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
    public override void OnEnter() { }
    public override void OnExit() { }
    public override void Update() { }
    public override void FixedUpdate() { }
    #endregion
}
