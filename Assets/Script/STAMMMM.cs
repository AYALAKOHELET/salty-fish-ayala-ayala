using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STAMMMM : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private int speed;

    private float vInput;
    private float hInput;

    private const string VERTICAL_AXIS = "Vertical";
    private const string HORIZPNTAL_AXIS = "Horizontal";

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        vInput = Input.GetAxis(VERTICAL_AXIS) * speed;
        hInput = Input.GetAxis(HORIZPNTAL_AXIS) * speed;

        Vector3 move = new Vector3(hInput, 0, vInput);
        rb.AddForce(move * speed * Time.deltaTime);
    }
}
