using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Video;

public class RestartVideo : MonoBehaviour
{
    public VideoPlayer player;

    private bool _isPlaying = true;

    private float _lastUpdate = 0.0f;

    private void Start()
    {
        _lastUpdate = Time.time;
    }

    private void Update()
    {
        if (Time.time - _lastUpdate < 1.0)
            return;
        
        if (OVRInput.Get(OVRInput.RawButton.X) || OVRInput.Get(OVRInput.RawButton.A))
        {
            _lastUpdate = Time.time;
            player.Stop();
            player.Play();
        }
        else if (OVRInput.Get(OVRInput.RawButton.Y) || OVRInput.Get(OVRInput.RawButton.B))
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
