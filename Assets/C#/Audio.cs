using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip Food;
    public AudioClip Cube;
    [Min(0)]
    public float Volume;


    private AudioSource _audio;
    public Eat eat;


    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
    public void FoodAudio()
    {
        _audio.PlayOneShot(Food, Volume);
    }

    public void CubeAudio()
    {
        _audio.PlayOneShot(Cube, Volume-4f);
    }
}
