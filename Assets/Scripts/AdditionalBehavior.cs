using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalBehavior : MonoBehaviour
{
    [SerializeField] private GameObject SceneSetup;
    private bool canPlay = false;
    private AudioSource _audioClip;
    // Start is called before the first frame update
    void Start()
    {
        _audioClip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudioClip()
    {
        canPlay = !canPlay;
        if(canPlay)
            _audioClip.Play();
        else
            _audioClip.Pause();
    }

    public void IncreaseRoomScale()
    {
        if(canPlay)
            SceneSetup.transform.localScale += Vector3.one * 0.1f;
        else
            SceneSetup.transform.localScale -= Vector3.one * 0.1f; 
    }
}
