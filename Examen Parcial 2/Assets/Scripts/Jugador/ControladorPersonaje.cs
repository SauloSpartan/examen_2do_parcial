using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public float playerSpeed;
    public float playerRotate;
    public bool playerMove = false;
    private Rigidbody rb;
    private Vector3 displacement;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }

    void FixedUpdate()
    {
        float hh = Input.GetAxis("Vertical");
        float hx = Input.GetAxis("Horizontal");
        PlayerMove(hh, hx);
        
    }

    void Update()
    {

    }

   

    void PlayerMove(float hh, float hx)
    {
        displacement.Set(-hx, 0f, -hh);
        displacement = displacement.normalized * playerSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + displacement);

        if (hx != 0f)
        {
            PlayerRotate(hx);
        }

        bool playerRun = hh != 0f || hx != 0f;


        if (playerRun)
        {
            playerMove = true;
        }
        else
        {
            playerMove = false;
        }
    }
    
    
    void PlayerRotate(float hx)
    {
        float interpolation = playerRotate * Time.deltaTime;
        Vector3 targetDirection = new Vector3(-hx, 0f, 0f);
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
        Quaternion newRotation = Quaternion.Lerp(rb.rotation, targetRotation, interpolation);
        rb.MoveRotation(newRotation);
    }

}
