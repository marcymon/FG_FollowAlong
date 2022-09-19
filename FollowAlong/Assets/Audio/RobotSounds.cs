using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSounds : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip jumpingFX;

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpingFX);
    }
}
