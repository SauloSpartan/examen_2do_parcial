using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float playerRotate;
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

        if(hh!=0f)
        {
            PlayerRotate(hh);
        }
    }

    void PlayerRotate(float hh)
    {
        float interpolation = playerRotate * Time.deltaTime;
        Vector3 targetDirection = new Vector3(-hh, 0f, 0f);
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
        Quaternion newRotation = Quaternion.Lerp(rb.rotation, targetRotation, interpolation);
        rb.MoveRotation(newRotation);
    }
}
