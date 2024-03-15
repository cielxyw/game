using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Three_Video : MonoBehaviour
{
    public static Three_Video instance;
    public RawImage rawImage;
    public VideoPlayer videoPlayer;
    void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rawImage = GetComponent<RawImage>();
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        rawImage.texture = videoPlayer.texture;
    }

}
