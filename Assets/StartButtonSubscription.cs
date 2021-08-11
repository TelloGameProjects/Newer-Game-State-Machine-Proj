using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonSubscription : MonoBehaviour
{
    [SerializeField] private Action OnStartButtonClick;

    public Action OnStartButtonClick1 { get => OnStartButtonClick; set => OnStartButtonClick = value; }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
