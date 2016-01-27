using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  public GameObject scoreUI;
  public GameObject highScoreUI;

  void Update()
  {
    if (DataManager.Instance.CurrentScore > DataManager.Instance.HighScore)
    {
      DataManager.Instance.HighScore = DataManager.Instance.CurrentScore;
    }

    if (scoreUI != null)
    {
      scoreUI.GetComponent<Text>().text = ("Score: " + DataManager.Instance.CurrentScore.ToString());
    }

    if(highScoreUI != null)
    {
      highScoreUI.GetComponent<Text>().text = ("High Score: " + DataManager.Instance.HighScore.ToString());
    }
  }
}