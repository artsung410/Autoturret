using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float TurretRotateSpeed;

    public GameObject BulletPrefab;
    
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private float spawnRate;
    private float elapsedTime;

    void Start()
    {
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        TurretRotateSpeed = 30f;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("플레이어 감지");

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
            transform.Rotate(new Vector3(0f, TurretRotateSpeed * Time.deltaTime, 0f));
        }
    }


}
