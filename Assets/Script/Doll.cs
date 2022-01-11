using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Doll : MonoBehaviour
{
    private Transform transform;
  
    [SerializeField] GameObject player;

    [SerializeField] private PlayerMovement playerScript;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] audioClips;

    public UnityAction <bool, int> isPlayerCaught;

    [SerializeField]
    private bool isCaught;

    [SerializeField]
    private int PlayerHp = 4;

    private bool IsCaught
    {
        get { return isCaught; }
        set 
        { 
            isCaught = value;
            if (isCaught)
            {
                isPlayerCaught?.Invoke(isCaught, PlayerHp);
            }
        }
    }
   
    private float angle1 = -70f;
    private float angle2 = 70f;
    float randomRotation = 0.0f;
   
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        transform = GetComponent<Transform>();
        randomRotation = Random.Range(0, 70);
        Rotate(); 
    }

   
    private void Rotate()
    {
       
       transform.rotation = Quaternion.Euler(0,  randomRotation, 0) ;
       StartCoroutine(Wait());
    }


    private IEnumerator Wait()
    {
            
        if (transform.eulerAngles.y > angle1 && transform.eulerAngles.y < angle2 && playerScript.isMoving == true)
        {
           
         player.transform.rotation = Quaternion.Euler(0, 0, 85);
         PlayerFall();
         Debug.Log("yes");
        }

        else
        {
            Debug.Log("no");
        }

        yield return new WaitForSeconds(1);
        transform.rotation = Quaternion.Euler(0, 180, 0);
        yield return new WaitForSeconds(Random.Range(1, 5));
        PlaySound();
    }

    private IEnumerator FallAgain()
    {
        yield return new WaitForSeconds(1f);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        isCaught = false;
    }

    private void PlayerFall()
    {
        isCaught = true;
        PlayerHp--;
        Debug.Log("Icatch You");    
        StartCoroutine(FallAgain());
    }
    private IEnumerator SoundBeforeRotate()
    {
        
        yield return new WaitForSeconds(1f);
        Rotate();
        
    }

    private void PlaySound()
    {
        audioSource.clip = audioClips[0];
        audioSource.Play();
        StartCoroutine(SoundBeforeRotate());
    }

}
