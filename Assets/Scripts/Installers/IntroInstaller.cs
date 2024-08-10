using Assets.Scripts.States.IntroStates;
using UnityEngine;
using Zenject;

public class IntroInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IntroStateMachineRunner>().FromComponentsInHierarchy().AsSingle();
    }
}
