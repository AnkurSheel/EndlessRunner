using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
  public void Start()
  {
    transform.GetChild(0).GetComponent<Text>().text = "Coins Collected : " + DataManager.Instance.CoinsCollected;
  }
  
  public void OnRestartPressed()
  {
    SceneManager.LoadScene("RunnerGame");
  }

  public void OnQuitPressed()
  {
    Application.Quit();
  }
}