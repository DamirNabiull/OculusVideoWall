using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Video;

public class RestartVideo : MonoBehaviour
{
    public VideoPlayer player;
    private void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.X))
        {
            player.Play();
        }
        else if (OVRInput.Get(OVRInput.RawButton.Y))
        {
            player.Stop();
        }
    }
}
