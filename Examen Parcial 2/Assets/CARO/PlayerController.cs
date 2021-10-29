using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody rb;
    private Vector3 displacement;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void FixedUpdate ()
    {
        float mh = Input.GetAxis("Horizontal");
        PlayerMove(mh);
    }

    void Update()
    {
        
    }

    void PlayerMove(float mh)
    {
        displacement.Set(mh,0f, 0f);
        displacement = displacement.normalized * playerSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + displacement);
    }
}
