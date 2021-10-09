using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource source;
    public List<AudioClip> music = new List<AudioClip>();
    [Range(1f, 3f)] public int musicPlaying = 1;
    void Start()
    {
        if(musicPlaying == 1)
        {
            source.clip = music[0];
        }
        if (musicPlaying == 2)
        {
            source.clip = music[1];
        }
        if (musicPlaying == 3)
        {
            source.clip = music[2];
        }
        source.Play();
    }

    void Update()
    {
        
    }
}
