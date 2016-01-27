using UnityEngine;
using System.Collections;

public class AudioFX : MonoBehaviour
{
  public AudioClip collect;

  public void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Coin")
    {
      GetComponent<AudioSource>().PlayOneShot(collect, 1.0f);
    }
  }
}