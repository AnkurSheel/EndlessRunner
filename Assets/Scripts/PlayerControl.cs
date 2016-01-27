using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
  public int PlayerSpeed = 10;
  public Vector3 JumpVelocity = new Vector3(0.0f, 10.0f, 0.0f);

  private bool onGround = true;

  public bool OnGround
  {
    set { onGround = value; }
  }

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
    if(onGround && Input.GetButton("Jump"))
    {
      GetComponent<Rigidbody>().AddForce(JumpVelocity, ForceMode.VelocityChange);
    }
  }
}