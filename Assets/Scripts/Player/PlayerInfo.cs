using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : Singleton<PlayerInfo>
{
    public float JumpSpeed;
    public Animator animator;
    public Rigidbody PlayerRigidbody;
    public float PlayerSpeed => InputManager.Instance.moveVector.magnitude;
    public bool isGrounded => (Mathf.Abs(PlayerInfo.Instance.PlayerRigidbody.velocity.y) < 0.001f);
    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetInteger("UseSkill", -1);
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    public void UpdateAnimatorParameters()
    {
        animator.SetFloat("MoveX", InputManager.Instance.moveVector.x);
        animator.SetFloat("MoveY", InputManager.Instance.moveVector.y);
        animator.SetFloat("Speed", InputManager.Instance.moveVector.magnitude);
        animator.SetFloat("VerticleSpeed", PlayerRigidbody.velocity.y);
        animator.SetFloat("VerticleRigidforce", MathF.Abs(PlayerRigidbody.velocity.y));
    }
}
