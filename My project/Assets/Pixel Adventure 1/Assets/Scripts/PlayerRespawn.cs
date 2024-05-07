using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    //variables

    public Animator animator;
    public void playerDamaged(){
        animator.Play("Hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
