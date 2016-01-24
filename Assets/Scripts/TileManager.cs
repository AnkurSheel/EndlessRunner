using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour
{

  public GameObject LevelPrefab;
  public GameObject CurrentLevelPiece;

  // Use this for initialization
  void Start()
  {
    SpawnLevelPiece();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void SpawnLevelPiece()
  {
    Instantiate(LevelPrefab, CurrentLevelPiece.transform.GetChild(0).position, Quaternion.identity);
  }
}
