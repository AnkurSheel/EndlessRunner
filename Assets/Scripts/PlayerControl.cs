using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
  public int PlayerSpeed = 10;
  public float JumpVelocity = 7.0f;

  private bool onGround = false;
  public bool OnGround
  {
    set { onGround = value; }
  }

  private Vector3 dir = Vector3.zero;
  private bool jumpPressed = false;
  
  void Start()
  {

  }

  void FixedUpdate()
  {
    float amountToMove = PlayerSpeed * Time.fixedDeltaTime;
    transform.Translate(dir * amountToMove);

    if(jumpPressed)
    {
      jumpPressed = false;
      GetComponent<Rigidbody>().velocity = new Vector3(0.0f, JumpVelocity, 0.0f);
    }
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
      jumpPressed = true;
    }
  }
}