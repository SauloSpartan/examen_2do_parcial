using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuertePersonaje : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f"))
        {
            anim.SetBool("IsAttack", true);
        }
        if (!Input.GetKey("f"))
        {
            anim.SetBool("IsAttack", false);
        }
    }
}
