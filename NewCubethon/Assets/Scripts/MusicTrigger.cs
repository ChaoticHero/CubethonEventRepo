using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MusicTrigger : MonoBehaviour
{
    public UnityEvent musicTrigger;
    public AudioSource song;

    private void OnTriggerEnter(Collider other)
    {
        musicTrigger.Invoke();
    }

    public void play()
    {
        song.Play();
    }
}
