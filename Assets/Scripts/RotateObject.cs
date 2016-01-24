using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour
{
  public int RotationSpeed = 5;

  void FixedUpdate()
  {
    transform.Rotate(Vector3.up * RotationSpeed * Time.fixedDeltaTime);
  }
}
