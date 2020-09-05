using UnityEngine.Audio;
using System;
using UnityEngine;


public class SoundManager : MonoBehaviour {

    public MySound[] sounds;


	// Use this for initialization
	void Awake () { 
		foreach (MySound so in sounds)
        {
            so.source =  gameObject.AddComponent<AudioSource>();
            so.source.clip = so.clip;
            so.source.pitch = so.pitch;
            so.source.volume = so.volume;
        }
	}
	
	// Update is called once per frame
	public void Play(string name)
    {
        MySound so = Array.Find(sounds, sound => sound.name == name);
        so.source.Play();
    }
}
