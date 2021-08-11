using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "StartButton", menuName = "Controls/StartButton")]
public class StartButton : ScriptableObject
{
    [SerializeField]
    private Button startButtonControl;

    public Button StartButtonControl { get => startButtonControl; set => startButtonControl = value; }

}
