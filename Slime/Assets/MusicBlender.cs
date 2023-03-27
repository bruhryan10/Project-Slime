using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBlender : MonoBehaviour
{
    public AudioSource labMusic;
    public AudioSource snowMusic;


    public enum Area { Lab, Snow }
    public Area areaSelection;

    public const float maxVolume = .25f;

  [SerializeField] private float blendLength = 2f;

    private float timeStartedBlending;

    private void OnTriggerEnter(Collider other)
    {
        timeStartedBlending = Time.time;
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            float timeSinceStarted = Time.time - timeStartedBlending;
            float percentage = timeSinceStarted / blendLength;
          
            if (areaSelection == Area.Lab)
            {
                labMusic.volume = Mathf.Lerp(labMusic.volume, maxVolume, percentage);
                snowMusic.volume = Mathf.Lerp(snowMusic.volume, 0f, percentage);
            }
            else if (areaSelection == Area.Snow)
            {
                snowMusic.volume = Mathf.Lerp(snowMusic.volume, maxVolume, percentage);
                labMusic.volume = Mathf.Lerp(labMusic.volume, 0f, percentage);
            }
        }

    }
}