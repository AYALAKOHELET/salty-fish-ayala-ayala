using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private GameObject doll;
   
    [SerializeField] private int speed;
    public bool isMoving = false;

    private float vInput;
    private float hInput;

    private const string VERTICAL_AXIS = "Vertical";
    private const string HORIZPNTAL_AXIS = "Horizontal";

    private Vector3 startPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = this.transform.position;
    }

    private void Update()
    {
        vInput = Input.GetAxis(VERTICAL_AXIS) * speed;
        hInput = Input.GetAxis(HORIZPNTAL_AXIS) * speed;

        Vector3 move = new Vector3(hInput, 0, vInput);
        rb.AddForce(move * speed * Time.deltaTime);
        if (rb.velocity.magnitude > 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }


    }

    public void ResetLocation()
    {
        this.transform.position = startPos;
    }

}