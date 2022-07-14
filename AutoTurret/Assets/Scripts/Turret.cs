
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public TurretTargeting Targeting;

    public Transform Target;

    public GameObject Bullet;

    public float Speed = 3f;
    private float spawnRateMin = 0.5f;
    private float spawnRateMax = 2f;
    private float spawnRate;
    private float elapsedTime;

    Vector3 TurretRotate = new Vector3(0f, 1f, 0f);

    void Start()
    {
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
    }

    void Update()
    {
        if (Targeting.isDetect)
        {
            Fire();
        }
    }

    void Fire()
    {
        elapsedTime += Time.deltaTime;

        transform.LookAt(Target);

        if (elapsedTime >= spawnRate)
        {
            GameObject bullet = Instantiate(Bullet, transform.position, transform.rotation);

            elapsedTime = 0f;

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}