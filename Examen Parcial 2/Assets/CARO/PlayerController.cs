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
        float hh = Input.GetAxis("Horizontal");
        PlayerMove(hh);
    }

    void Update()
    {
        
    }

    void PlayerMove(float hh)
    {
        displacement.Set(-hh, 0f, 0f);
        displacement = displacement.normalized * playerSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + displacement);
    }
}
