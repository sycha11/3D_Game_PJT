using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _animator;
    // Animator 컴포넌트 변수 추가

    private Rigidbody rigid;

    private Transform _transform;
    private float _horizontal = 0.0f;
    private float _vertical = 0.0f;

    public float moveSpd = 5.0f;
    public float rotateSpd = 100.0f;

    public int jumpPower;
    // Use this for initialization
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>(); // 컴포넌트를 변수에 할당
        _animator = GetComponentInChildren<Animator>(); // Animator 컴포넌트는 player 오브젝트 하위에 존재하므로 InChildren사용

        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        // 변위 값을 계산하기 위한 Vector3 변수: 전후진과 좌우 이동값 저장
        Vector3 moveDirect = (Vector3.forward * _vertical) + (Vector3.right * _horizontal);
        
        // 게임 오브젝트의 이동처리를 편하게 할 수 있는 함수
        _transform.Translate(moveDirect.normalized * Time.deltaTime * moveSpd, Space.Self);

        //캐릭터의 회전을 위한 함수
        _transform.Rotate(Vector3.up * Time.deltaTime * rotateSpd * Input.GetAxis("Mouse X"));
    
        if(_vertical >= 0.1f)
        {
            _animator.SetBool("IsWalk", true);
        }
        else if(_vertical <= -0.1f)
        {
            _animator.SetBool("IsWalk", true);
        }
        else if(_horizontal >= 0.1f)
        {
            _animator.SetBool("IsWalk", true);
        }
        else if (_horizontal <= -0.1f)
        {
            _animator.SetBool("IsWalk", true);
        }
        else
        {
            _animator.SetBool("IsWalk", false);
        }
        
        Jump();
       
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

 
    
}
