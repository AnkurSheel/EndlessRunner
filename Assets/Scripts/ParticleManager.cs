using UnityEngine;
using System.Collections;

public class ParticleManager : MonoBehaviour
{
  public GameObject CoinCollectParticleEffect;

  private static ParticleManager instance;
  public static ParticleManager Instance
  {
    get { return instance; }
  }

  // Use this for initialization
  void Start()
  {
    instance = this;
  }

  public void OnCoinCollected(Vector3 coinPosition)
  {
    Instantiate(CoinCollectParticleEffect, coinPosition,CoinCollectParticleEffect.transform.rotation);
  }
}