using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    [SerializeField] List<CharacterData> enemyDatas = new();
    [SerializeField] List<CharacterData> playerDatas = new();
    void Start()
    {
        SpawnPlayer();
        SpawnEnemies();
    }
    void Update()
    {
        Debug.Log($"Лист энеми: {enemyDatas.Count}." +
        $"Лист плеер: {playerDatas.Count}");
    }
    void SpawnEnemies()
    {
        int numData = Random.Range(0, enemyDatas.Count);
        Enemy enemy = Character.GetNewEnemy(enemyDatas[numData]);
        Vector3 randomPos = Random.insideUnitSphere * 50;
        randomPos.y = 10;
        enemy.gameObject.transform.position = randomPos;
    }
    void SpawnPlayer()
    {
        int numData = Random.Range(0, playerDatas.Count);
        Player player = Character.GetNewPlayer(playerDatas[numData]);

        Vector3 randomPos = Random.insideUnitSphere * 50;
        randomPos.y = 10;
        player.gameObject.transform.position = randomPos;
    }
}