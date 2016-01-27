using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
  private PlayerControl controlScript;
  public GameObject restartUI;

  public void Start()
  {
    controlScript = gameObject.GetComponent<PlayerControl>();
  }

  public void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Enemy")
    {
      Vector3 normal = collision.contacts[0].normal;
      if (Mathf.Abs(normal.z) > Mathf.Abs(normal.y))
      {
        OnPlayerDied();
        
      }
      Debug.Log(normal);
    }
    else if(collision.gameObject.tag == "Ground")
    {
      controlScript.OnGround = true;
    }
  }

  public void OnCollisionExit(Collision collision)
  {
    if (collision.gameObject.tag == "Ground")
    {
      controlScript.OnGround = false;
    }
  }

  public void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Coin")
    {
      OnCoinCollected(other);
    }
  }

  private void OnPlayerDied()
  {
    DataManager.Instance.Save();
    restartUI.gameObject.SetActive(true);
    GetComponent<Rigidbody>().isKinematic = true;
    GetComponent<MeshRenderer>().enabled = false;
    GetComponent<PlayerControl>().enabled = false;
    GetComponentInChildren<ParticleSystem>().Play();
  }

  private void OnCoinCollected(Collider other)
  {
    int points = other.gameObject.GetComponent<Coin>().points;
    DataManager.Instance.CurrentScore += points;
    DataManager.Instance.CoinsCollected++;
    ParticleManager.Instance.OnCoinCollected(other.gameObject.transform.position);
    Destroy(other.gameObject);
  }
}

