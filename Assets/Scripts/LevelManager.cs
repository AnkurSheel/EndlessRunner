﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
  public GameObject LevelPrefab;
  public GameObject CurrentLevelPiece;

  private GameObject PreviousLevelPiece;

  private static LevelManager instance;
  public static LevelManager Instance
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
    if (PreviousLevelPiece == null)
    {
      PreviousLevelPiece = CurrentLevelPiece;
      CurrentLevelPiece = (GameObject)Instantiate(LevelPrefab, CurrentLevelPiece.transform.GetChild(0).position, Quaternion.identity);
    }
    else
    {
      PreviousLevelPiece.transform.position = CurrentLevelPiece.transform.GetChild(0).position;
      GameObject temp = PreviousLevelPiece;
      PreviousLevelPiece = CurrentLevelPiece;
      CurrentLevelPiece = temp;
      
    }
    
  }
}
