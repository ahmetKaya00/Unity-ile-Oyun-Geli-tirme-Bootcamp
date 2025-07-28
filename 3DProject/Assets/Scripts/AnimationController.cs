using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _animator.SetBool("isWalking", true);
            _animator.SetBool("isIdle", false);
        }
        else
        {
            _animator.SetBool("isWalking", false);
            _animator.SetBool("isIdle", true);
        }
    }
}
