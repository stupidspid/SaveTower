using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnEnemies : MonoBehaviour
{
    private NinjaInstance.NinjaFactory _ninjaFactory;
    private WarriorInstance.WarriorFactory _warriorFactory;
    
    [Inject]
    private void Init(NinjaInstance.NinjaFactory ninjaFactory, WarriorInstance.WarriorFactory warriorFactory)
    {
        _ninjaFactory = ninjaFactory;
        _warriorFactory = warriorFactory;
    }

    private void Start()
    {
        StartCoroutine(SpawnNinjas());
    }

    private IEnumerator SpawnNinjas()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            _ninjaFactory.Create();
            yield return new WaitForSeconds(1);
            _warriorFactory.Create();
        }
    }
}
