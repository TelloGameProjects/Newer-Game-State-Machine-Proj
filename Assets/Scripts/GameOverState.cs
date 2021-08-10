using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class GameOverState : State
{    
    public GameOverState()
    {
        Name = "GameOverState";
    }
    #region Class Methods
    public override void OnEnter() { Debug.Log("GameOverState.Awake()"); }
    public override void OnExit() { }
    public override void Update() { }
    public override void FixedUpdate() { }
    #endregion
}
