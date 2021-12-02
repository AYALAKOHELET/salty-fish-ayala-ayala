using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollController : MonoBehaviour
{
 
    private Animator anim;

    [SerializeField] private float minTime = 5;
    [SerializeField] private float maxTime = 15;

    [SerializeField] private int minAnimaoinPlay = 1;
    [SerializeField] private int manAnimaoinPlay = 3;

    private bool animaoinPlay;

    private void Start()
    {
        animaoinPlay = false;
        anim = GetComponent<Animator>();
        StartCoroutine(rotateLoop());
    }


    private IEnumerator rotateLoop()
    {

        while (true)
        {
            
            yield return new WaitForSeconds(Random.Range(minTime, maxTime ));

            Rotate();
            //anim.SetInteger("AnimoinPlay", 0);
        }


    }
    public void Rotate()
    {

        anim.SetInteger("AnimoinPlay",  Random.Range(minAnimaoinPlay, manAnimaoinPlay));
        print("AnimoinPlay");
        

    }



}


