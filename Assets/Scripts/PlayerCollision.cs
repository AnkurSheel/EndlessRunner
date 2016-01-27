using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
  private PlayerControl controlScript;

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
    SceneManager.LoadScene("RunnerGame");
  }

  private void OnCoinCollected(Collider other)
  {
    DataManager.Instance.CurrentScore++;
    ParticleManager.Instance.OnCoinCollected(other.gameObject.transform.position);
    Destroy(other.gameObject);
  }
}

