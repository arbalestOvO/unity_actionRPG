using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : Singleton<PlayerInfo>
{
    public float JumpSpeed;
    public Animator animator;
    public Rigidbody PlayerRigidbody;
    public PlayerStateMachineeComponent playerStateMachine;
    public float PlayerSpeed => InputManager.Instance.moveVector.magnitude; 
    private void Awake()
    {
        animator = GetComponent<Animator>();
        PlayerRigidbody = GetComponent<Rigidbody>();
        playerStateMachine = GetComponent<PlayerStateMachineeComponent>();
    }

    public void UpdateAnimatorParameters()
    {
        animator.SetFloat("MoveX", InputManager.Instance.moveVector.x);
        animator.SetFloat("MoveY", InputManager.Instance.moveVector.y);
        animator.SetFloat("Speed", InputManager.Instance.moveVector.magnitude);
        animator.SetFloat("VerticleSpeed", MathF.Abs(PlayerRigidbody.velocity.y));
        animator.SetFloat("VerticleRigidforce", MathF.Abs(PlayerRigidbody.velocity.y));
    }
}
