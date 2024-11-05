using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieWake : MonoBehaviour
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
            Debug.Log("IN");
            _animator.SetBool("IsWalk", true);
            GameObject.Find("TimeOut").GetComponent<TimeAttack>().done -= 30;
            AudioSource zombie = GetComponent<AudioSource>();
            zombie.Play();
        }
        else
        {
            _animator.SetBool("IsWalk", false);
        }
       }
}
