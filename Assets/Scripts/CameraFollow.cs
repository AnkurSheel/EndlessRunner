using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

  private GameObject player;
  public float CameraSpeed = 5.0f;

	void Start () {
    player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void FixedUpdate () {
    Vector3 campos = transform.position;
    campos.z = player.transform.position.z - 3.0f;
    transform.position = Vector3.Lerp(transform.position, campos, 3 * Time.fixedDeltaTime);
	}
}
