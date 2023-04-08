using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class impactSFXArray : MonoBehaviour
{
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = Random.Range(0.9f, 1f);
    }
  AudioSource audioSource;
  public AudioClip[] impactsound;
  private float magnitudeChecker;

  void OnCollisionEnter(Collision collision)
  {
      magnitudeChecker = collision.relativeVelocity.magnitude;
      if (magnitudeChecker > 0.5f)
      {
          audioSource.PlayOneShot(impactsound[Random.Range(0,impactsound.Length+1)], magnitudeChecker/10);
      }
  }
}