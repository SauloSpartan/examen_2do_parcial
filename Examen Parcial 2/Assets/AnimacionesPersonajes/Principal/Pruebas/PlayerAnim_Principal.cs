using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim_Principal : MonoBehaviour
{
    private ControladorPersonaje player;
    private Animator playerAnim;

    void Awake()
    {
        player = FindObjectOfType<ControladorPersonaje>();
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
            if (Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("Run", true);
            }
            if (!Input.GetKey(KeyCode.LeftShift))
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
