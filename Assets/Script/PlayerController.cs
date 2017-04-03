using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]


public class PlayerController : MonoBehaviour {


    public AudioClip jumpVoice;
    public AudioClip damageVoice;

    private AudioSource mAudio;
    // Use this for initialization
    void Start () {
        mAudio = GetComponent<AudioSource>();
	}
	
    void onDamage()
    {
        PlayerVoice(damageVoice);
    }
    void Jump()
    {
        PlayerVoice(jumpVoice);
    }

    void PlayerVoice(AudioClip clip)
    {
        mAudio.Stop();
        mAudio.PlayOneShot(clip);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
