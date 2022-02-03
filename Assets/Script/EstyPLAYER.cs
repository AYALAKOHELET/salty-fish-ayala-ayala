using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstyPLAYER : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 150f;

    private Animator anim;

    private CharacterController chController;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        chController = GetComponent<CharacterController>();

    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        anim.SetFloat("SpeedMove", vertical);
        chController.SimpleMove(transform.forward * moveSpeed * vertical * Time.deltaTime);
        float horizontal = Input.GetAxis("Horizontal");
        
    }
}
