using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class MySound {

    public string name;

    public AudioClip clip;

    [Range(0.1f, 4f)]
    public float pitch;
    [Range(0f, 2f)]
    public float volume;


    [HideInInspector]
    public AudioSource source;

}
 