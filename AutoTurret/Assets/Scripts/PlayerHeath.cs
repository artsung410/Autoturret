using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeath : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            Debug.Log("★★★플레이어 사망!!★★★");
            Die();
        }
    }

    void Die()
    {
        gameObject.SetActive(false);
    }
}
