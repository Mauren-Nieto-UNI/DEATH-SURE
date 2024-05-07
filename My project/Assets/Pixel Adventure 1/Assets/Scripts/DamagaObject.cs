using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class DamagaObject : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            UnityEngine.Debug.Log("Player Damaga");
            collision.transform.GetComponent<PlayerRespawn>().playerDamaged();
        }
    }
}
