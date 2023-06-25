using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.HierarchicalFiniteStateMachine;
public class PlayerStateMachineeComponent : MonoBehaviour
{
    private PlayerStateMachinee _stateMachine;
    private void Awake()
    {
        _stateMachine = AbstractHierarchicalFiniteStateMachine.CreateRootStateMachine<PlayerStateMachinee>("PlayerStateMachinee");
    }
    private void Start()
    {
        _stateMachine.OnEnter();
    }
    private void Update()
    {
        _stateMachine.OnUpdate();
    }
    private void FixedUpdate()
    {
        _stateMachine.OnFixedUpdate();
    }
}
