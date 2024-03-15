using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMgr : MonoBehaviour
{
    AudioSource audioSource;
    public static AudioMgr instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //从resource中加载audioClip
    public void LoadAudioClip(string path)
    {
        AudioClip audioClip = Resources.Load<AudioClip>("Audio/" + path);
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
