using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameStateChangeTouch : ChangeGameState, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        ChangeState();
    }
}
