using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Pasaste al siguiente nivel");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
          
        }
    }
}
