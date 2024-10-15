using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustDialogue : MonoBehaviour
{

    public AudioClip dialogueAudio;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(dialogueAudio, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
