using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeath : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            Debug.Log("�ڡڡ��÷��̾� ���!!�ڡڡ�");
            Die();
        }
    }

    void Die()
    {
        gameObject.SetActive(false);
    }
}
