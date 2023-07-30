using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private CastleInstance castleInstance;
    [SerializeField] private NinjaInstance ninjaInstance;
    [SerializeField] private WarriorInstance warriorInstance;
    public override void InstallBindings()
    {
        Container.Bind<CastleInstance>().FromComponentInNewPrefab(castleInstance).AsSingle().NonLazy();
        InstallFactories();
    }
    
    private void InstallFactories()
    {
        Container.BindFactory<NinjaInstance, NinjaInstance.NinjaFactory>().FromComponentInNewPrefab(ninjaInstance).AsSingle().
            NonLazy();
        Container.BindFactory<WarriorInstance, WarriorInstance.WarriorFactory>().FromComponentInNewPrefab(warriorInstance).AsSingle().
            NonLazy();
    }
}
