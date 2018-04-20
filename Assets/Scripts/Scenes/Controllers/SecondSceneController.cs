using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class SecondSceneController : VSceneController
{
    public RawImage ColorImage;
    public Color Color;

    private AudioSource audioSource;
    private VideoPlayer videoPlayer;

    private bool hasPlayed = false;

    private void Start()
    {
        ColorImage.color = Color;
    }

    public void OnBackClicked()
    {
        LoadScene(VSceneFactory.Instance.FirstScene());
    }
}
