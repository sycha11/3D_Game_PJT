using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meetZombie : MonoBehaviour
{

    private Animator _animator;
    void Start()
    {

        _animator = GetComponentInChildren<Animator>(); // Animator 컴포넌트는 player 오브젝트 하위에 존재하므로 InChildren사용

    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            _animator.SetBool("IsBack", true);
        }
    }
}