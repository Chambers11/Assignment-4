using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    AudioSource animationSoundPlayer;


  
    // Start is called before the first frame update
    private void Awake()
    {
        animationSoundPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void PlayerFootstepSound()
    {
        animationSoundPlayer.Play();
    }
}
