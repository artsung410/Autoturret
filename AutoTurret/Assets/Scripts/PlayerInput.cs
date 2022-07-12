using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public float X { get; private set; }
    public float Y { get; private set; }

    void Update()
    {
        // ���� ���� ������, �⺻ ������ �ʱ�ȭ
        X = Y = 0f;

        // ���� �������� �Է� ���� ����
        X = Input.GetAxis("Horizontal"); // ~1 ~ 1
        Y = Input.GetAxis("Vertical"); // -1 ~ 1
    }
}
