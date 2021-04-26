using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(AudioSource))]
public class AudioMGR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        groundMusic.Play();
    }

    public AudioSource groundMusic;
    public AudioSource skyMusic;
    public AudioSource caveMusic;
    public AudioSource titleMusic;
    public AudioSource deadMusic;

    // Update is called once per frame
    void Update()
    {
        
    }
}
