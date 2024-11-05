using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // 주인공 캐릭터의 Transform 컴포넌트 변수
    public Transform targetTransform;
    // 주인공 캐릭터와의 거리
    public float dist = 2.0f;
    // 주인공 캐릭터와의 높이
    public float height = 0.5f;
    // 부드러운 추적을 위한 변수
    public float dampTrace = 20.0f;

    // 카메라 자신의 Transform 컴포넌트
    private Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //선형 보간 시켜주는 함수를 이용하여 카메라 위치 지정
        _transform.position = Vector3.Lerp(_transform.position, targetTransform.position - (targetTransform.forward * dist) + (Vector3.up * height), Time.deltaTime * dampTrace);

        // 카메라가 타켓을 바라볼 수 있게 설정
        _transform.LookAt(targetTransform.position);
    }
}
