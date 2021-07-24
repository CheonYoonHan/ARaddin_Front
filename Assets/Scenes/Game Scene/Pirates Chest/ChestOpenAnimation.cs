using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpenAnimation : MonoBehaviour
{
    GameObject player;
    Animator anim;
    public static bool isPlayerEnter;
    

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera");
        anim = GetComponentInChildren<Animator>();

        isPlayerEnter = false;
    }

    void Update()
    {
        if (isPlayerEnter)
        {
            anim.SetBool("IsOpen", true);
        }
        else
        {
            anim.SetBool("IsOpen", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
        if (collision.gameObject == player)
        {
            isPlayerEnter = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == player)
        {
            isPlayerEnter = false;
        }
    }
}
