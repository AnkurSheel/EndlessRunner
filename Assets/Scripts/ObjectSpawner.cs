using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
  public GameObject Player;
  public GameObject[] Coins;
  public GameObject Enemy;

  public float MinCoinSpawnTimer = 2.0f;
  public float MaxCoinSpawnTimer = 5.0f;
  public float MinEnemySpawnTimer = 5.0f;
  public float MaxEnemySpawnTimer = 7.0f;
  private float timeLeftForCoinSpawn;
  private float timeLeftForEnemySpawn;

  public void Start()
  {
    SpawnCoins();

    timeLeftForCoinSpawn = Random.Range(MinCoinSpawnTimer, MaxCoinSpawnTimer);
    timeLeftForEnemySpawn = Random.Range(MinEnemySpawnTimer, MaxEnemySpawnTimer);
  }

  public void Update()
  {
    if(timeLeftForCoinSpawn > 0.0f)
    {
      timeLeftForCoinSpawn -= Time.deltaTime;
      if(timeLeftForCoinSpawn < 0.0f)
      {
        timeLeftForCoinSpawn = Random.Range(MinCoinSpawnTimer, MaxCoinSpawnTimer);
        SpawnCoins();
      }
    }
    if (timeLeftForEnemySpawn > 0.0f)
    {
      timeLeftForEnemySpawn -= Time.deltaTime;
      if (timeLeftForEnemySpawn < 0.0f)
      {
        timeLeftForEnemySpawn = Random.Range(MinEnemySpawnTimer, MaxEnemySpawnTimer);
        SpawnEnemy();
      }
    }
  }

  private void SpawnCoins()
  {
    if(Coins.Length > 0)
    {
      Instantiate(Coins[(Random.Range(0, Coins.Length))], new Vector3(Random.Range(-3.0f, 3.0f), 0.0f, Player.transform.position.z + Random.Range(10.0f, 15.0f)), Quaternion.identity);
    }
  }

  private void SpawnEnemy()
  {
    if (Enemy != null)
    {
      GameObject tempEnemy = (GameObject)Instantiate(Enemy, new Vector3(Random.Range(-2.0f, 2.0f), 0.0f, Player.transform.position.z + Random.Range(10.0f, 20.0f)), Quaternion.identity);
      tempEnemy.transform.localScale = new Vector3(Random.Range(1, 5), Random.Range(1, 4), Random.Range(1, 10));
    }
  }
}