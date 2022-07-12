using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject BulletPrefab;

    public float TurretRotationSpeed = 15f;

    private float spawnRateMin = 0.5f;
    private float spawnRateMax = 2f;
    private float spawnRate;
    private float elapsedTime;

    void Start()
    {
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            elapsedTime += Time.deltaTime;

            Transform Target = other.transform;
            transform.LookAt(Target);

            if (elapsedTime >= spawnRate)
            {
                GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
                bullet.transform.LookAt(Target);

                elapsedTime = 0;
                spawnRate = Random.Range(spawnRateMin, spawnRateMax);
            }
        }
        else
        {
            Vector3 TurretRotate = new Vector3(0f, TurretRotationSpeed * Time.deltaTime, 0f);
            transform.Rotate(TurretRotate);
           
        }
    }
}
