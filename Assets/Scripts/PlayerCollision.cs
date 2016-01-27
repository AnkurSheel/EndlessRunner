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
      SceneManager.LoadScene("RunnerGame");
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
      Destroy(other.gameObject);
    }
  }
}

