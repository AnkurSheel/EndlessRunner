using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
  public void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Enemy")
    {
      SceneManager.LoadScene("RunnerGame");
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

