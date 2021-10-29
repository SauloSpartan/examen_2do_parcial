using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMuerte : MonoBehaviour
{
    Animator E_animator;
    // Start is called before the first frame update
    void Start()
    {
        E_animator = GetComponent<Animator>();
    }

    void Update()
    {
        /*if (Input.GetKey("w"))
        {
            E_animator.SetBool("IsDeath", true);
        }*/

    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sword")
        {
            //E_animator.SetBool("IsDeath", true);
            E_animator.SetTrigger("IsDeath2");
        }
     
    }*/

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Sword")
        {
            //E_animator.SetBool("IsDeath", true);
            E_animator.SetTrigger("IsDeath2");
        }

    }
}
