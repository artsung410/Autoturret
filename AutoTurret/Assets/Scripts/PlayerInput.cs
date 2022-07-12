using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public float X { get; private set; }
    public float Y { get; private set; }

    void Update()
    {
        // 이전 값을 날리고, 기본 값으로 초기화
        X = Y = 0f;

        // 현재 프레임의 입력 값을 저장
        X = Input.GetAxis("Horizontal"); // ~1 ~ 1
        Y = Input.GetAxis("Vertical"); // -1 ~ 1
    }
}
