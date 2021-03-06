using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput Input;
    private Rigidbody PlayerRigid;

    public float Speed = 10f;
    void Start()
    {
        Input = GetComponent<PlayerInput>();
        PlayerRigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xSpeed = Input.X * Speed;
        float zSpeed = Input.Z * Speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        PlayerRigid.velocity = newVelocity;

    }
}
