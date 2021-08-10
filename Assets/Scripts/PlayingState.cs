using System;
using UnityEngine;
using Vast.StateMachine;


[Serializable]
public class PlayingState : State
{

    public PlayingState()
    {
        Name = "PlayingState";
    }
    #region Class Methods
    public override void OnEnter() { }
    public override void OnExit() { }
    public override void Update() { }
    public override void FixedUpdate() { }
    #endregion
}
