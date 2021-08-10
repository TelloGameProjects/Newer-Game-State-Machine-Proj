using System;
using UnityEngine;
using Vast.StateMachine;


[Serializable]
public class PauseState : State
{

    public PauseState()
    {
        Name = "PauseState";
    }
    #region Class Methods
    public override void OnEnter() { Debug.Log("PauseState Awake()"); }
    public override void OnExit() { }
    public override void Update() { }
    public override void FixedUpdate() { }
    #endregion
}
