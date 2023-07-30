using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointLogic : MonoBehaviour
{
    [SerializeField] private CornerType cornerType;
    [SerializeField] private float castleOffset = 2;
    private Camera mainCamera;
    
    public void Start()
    {
        mainCamera = Camera.main;
        SetCornerToSpawn(cornerType);
    }

    private void SetCornerToSpawn(CornerType cornerType)
    {
        switch (cornerType)
        {
            case CornerType.LEFT_UP:
            {
                var worldPoint = new Vector2(0, Screen.height);
                transform.position = new Vector3(mainCamera.ScreenToWorldPoint(worldPoint).x,
                    mainCamera.ScreenToWorldPoint(worldPoint).y, 0);
                break;
            }
            case CornerType.RIGHT_UP:
            {
                var worldPoint = new Vector2(Screen.width, Screen.height);
                transform.position = new Vector3(mainCamera.ScreenToWorldPoint(worldPoint).x,
                    mainCamera.ScreenToWorldPoint(worldPoint).y, 0);
                break;
            }
            case CornerType.LEFT_DOWN:
            {
                var worldPoint = new Vector2(0, 0);
                transform.position = new Vector3(mainCamera.ScreenToWorldPoint(worldPoint).x + castleOffset,
                    mainCamera.ScreenToWorldPoint(worldPoint).y + castleOffset, 0);
                break;
            }
            case CornerType.RIGHT_DOWN:
            {
                var worldPoint = new Vector2(Screen.width, 0);
                transform.position = new Vector3(mainCamera.ScreenToWorldPoint(worldPoint).x,
                    mainCamera.ScreenToWorldPoint(worldPoint).y, 0);
                break;
            }
        }
    }
}

public enum CornerType
{
    NONE = 0,
    LEFT_UP = 1,
    RIGHT_UP = 2,
    LEFT_DOWN = 3,
    RIGHT_DOWN = 4,
}
