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

        if (hh != 0f)
        {
            PlayerRotate(hh);
        }

        bool playerRun = hh != 0f;
        if (playerRun)
        {
            playerMove = true;
        }
        else
        {
            playerMove = false;
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
