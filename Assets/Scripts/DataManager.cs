using UnityEngine;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class DataManager : MonoBehaviour
{
  private int currentScore = 0;
  public int CurrentScore
  {
    get { return currentScore; }
    set { currentScore = value; }
  }

  private int highScore = 0;
  public int HighScore
  {
    get { return highScore; }
    set { highScore = value; }
  }

  private static DataManager instance;
  public static DataManager Instance
  {
    get { return DataManager.instance; }
  }

  void Awake()
  {
    if (instance == null)
    {
      DontDestroyOnLoad(instance);
      instance = this;
    }
    else
    {
      Destroy(gameObject);
    }
    Load();
  }
  
  public void Save()
  {
    BinaryFormatter bin = new BinaryFormatter();
    FileStream file = File.Create(Application.persistentDataPath + "/gameinfo.dat");
    GameData data = new GameData();
    data.highScore = highScore;
    bin.Serialize(file, data);
    file.Close();
  }

  public void Load()
  {
    if(File.Exists(Application.persistentDataPath + "/gameinfo.dat"))
    {
      BinaryFormatter bin = new BinaryFormatter();
      FileStream file = File.Open(Application.persistentDataPath + "/gameinfo.dat", FileMode.Open);
      GameData data = (GameData)bin.Deserialize(file);
      highScore = data.highScore;
    }
  }
}

[Serializable]
class GameData
{
  public int highScore = 0;
}