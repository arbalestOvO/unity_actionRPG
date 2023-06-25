using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : Singleton<PlayerInfo>
{
    public Animator animator;
    public float PlayerSpeed => InputManager.Instance.moveVector.magnitude; 
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
}
