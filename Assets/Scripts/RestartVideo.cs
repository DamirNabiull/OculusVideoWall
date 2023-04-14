using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Video;

public class RestartVideo : MonoBehaviour
{
    public VideoPlayer player;

    private bool _isPlaying = true;
    
    private void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.X))
        {
            player.Stop();
            player.Play();
        }
        else if (OVRInput.Get(OVRInput.RawButton.Y))
        {
            if (_isPlaying)
            {
                player.Pause();
                _isPlaying = false;
            }
            else
            {
                player.Play();
                _isPlaying = true;
            }
        }
    }
}
