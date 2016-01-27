using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour
{
  public float Delay = 30.0f;

  void Start()
  {
    StartCoroutine(DestroyMe());
  }

  IEnumerator DestroyMe()
  {
    yield return new WaitForSeconds(Delay);
    Destroy(this.gameObject);
  }
}