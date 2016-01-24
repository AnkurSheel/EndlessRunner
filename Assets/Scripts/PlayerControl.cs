using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
  public int PlayerSpeed = 10;
  private Vector3 dir = Vector3.zero;

  void Start()
  {

  }

  void FixedUpdate()
  {
    float amountToMove = PlayerSpeed * Time.fixedDeltaTime;
    transform.Translate(dir * amountToMove);
  }

  void Update()
  {
    dir = transform.forward;

    if (Input.GetAxis("Horizontal") < 0)
    {
      dir -= transform.right;
    }
    else if (Input.GetAxis("Horizontal") > 0)
    {
      dir += transform.right;
    }
  }
}