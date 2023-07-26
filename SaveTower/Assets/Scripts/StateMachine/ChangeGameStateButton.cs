using System;
using System.Collections;
using System.Collections.Generic;
using StateMachine;
using UI;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ChangeGameStateButton : ChangeGameState
{
    [SerializeField] private Button button;

    private void OnValidate()
    {
        if (button == null)
            button = GetComponent<Button>();
    }
    
    private void OnEnable()
    {
        button.onClick.AddListener(ChangeState);
    }
}
