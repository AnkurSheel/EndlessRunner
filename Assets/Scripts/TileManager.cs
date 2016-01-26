using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour
{
  public GameObject LevelPrefab;
  public GameObject CurrentLevelPiece;

  private static TileManager instance;
  public static TileManager Instance
  {
    get { return instance; }
  }

  // Use this for initialization
  void Start()
  {
    instance = this;
  }

  public void SpawnLevelPiece()
  {
    CurrentLevelPiece = (GameObject)Instantiate(LevelPrefab, CurrentLevelPiece.transform.GetChild(0).position, Quaternion.identity);
  }
}
