using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour
{

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void OnTriggerExit(Collider other)
  {
    if(other.tag == "Player")
    {
      TileManager.Instance.SpawnLevelPiece();
    }
  }

}
