using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheShooterDoll : MonoBehaviour
{
    //[SerializeField]
    //private GameObject gameObject;
    private Transform target;

    //private RaycastHit hit;

    RaycastHit hit = new RaycastHit();

    [SerializeField]
    private float speed;

    private GameObject tempObject;

    // Start is called before the first frame update
    void Start()
    {
        
        //transform.rotation = gameObject.GetComponent<Transform>().rotation;  
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),100))

        {
             tempObject = hit.collider.gameObject;
             hit.collider.gameObject.GetComponent<Transform>().rotation = target.rotation;
            //Vector3 targetDirection = target.position - transform.position;
            //float singleStep = speed * Time.deltaTime;
            //Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
            //Debug.DrawRay(transform.position, newDirection, Color.red);
            //transform.rotation = Quaternion.LookRotation(newDirection);
            
                Debug.Log("I cacth you");
        }
    }
    
       
}
