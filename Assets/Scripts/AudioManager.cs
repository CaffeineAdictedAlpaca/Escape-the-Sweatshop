using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
// Adrian

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource walkSource;
    [SerializeField] AudioSource sprintSource;
    [Header("Audio Clips")]
    public AudioClip background;
    public AudioClip walk;
    public AudioClip sprint;

    private void Start()
    {
        // Spelar bakgrundsmusiken n�r spelet startar - Adrian
        musicSource.clip = background;
        musicSource.Play();
    }

    private void Update()
    {
        // Spelar walking sound n�r man g�r - Adrian
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                walkSource.enabled = false;
                sprintSource.enabled = true;
            }
            else
            {
                walkSource.enabled = true;
                sprintSource.enabled = false;
            }
        }
        else
        {
            walkSource.enabled = false;
            sprintSource.enabled = false;
        }
    }
        
}
