using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private PlayerController player;
    private Animator playerAnim;
    
    void Awake()
    {
        player = FindObjectOfType<PlayerController>();
        playerAnim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        WalkAnim();
    }

    void Update()
    {
      
    }

    void WalkAnim()
    {
        if (player.playerMove)
        {
            if(Input.GetKey("r"))
            {
                playerAnim.SetBool("Run", true);
            }
            if (!Input.GetKey("r"))
            {
                playerAnim.SetBool("Run", false);
            }

         
        playerAnim.SetBool("Walk", true);
        
        }
        else
        {
            playerAnim.SetBool("Walk", false);
        }
    }

}
