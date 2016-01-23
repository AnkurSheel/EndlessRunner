using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

  public static int PlayerSpeed = 10;

	void FixedUpdate () 
  {
    gameObject.transform.Translate(gameObject.transform.forward * PlayerSpeed * Time.fixedDeltaTime);
	}
}
