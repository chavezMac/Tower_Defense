using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public TextMeshProUGUI waveCountdownText;
    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private int waveIndex = 0;
    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {
        Debug.Log("Wave Incoming");
        waveIndex++;

        for(int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
