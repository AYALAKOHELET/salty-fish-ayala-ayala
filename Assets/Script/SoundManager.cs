using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private Doll Doll;

    private AudioSource audioSource;
    [SerializeField] private AudioClip[] audioClips;

    private Doll doll;

    // Start is called before the first frame update
    void Start()
    {
        Doll.isPlayerCaught += PlaySound;
        audioSource = this.GetComponent<AudioSource>();
    }


    private void PlaySound( bool isCaghut, int PlayerHP)
    {
        if (isCaghut)
        {
            audioSource.clip = audioClips[1];
            audioSource.Play();
        }
         if (PlayerHP == 0)
        {
            audioSource.clip = audioClips[2];
            audioSource.Play();
        }
        
    }
}
