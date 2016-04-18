using UnityEngine;
using System.Collections;
using GamepadInput;

public class Spawner : MonoBehaviour
{

    public AudioClip audioClip;
    public AudioSource music;

    public GameObject[] Hazards;
    public Vector3 SpawnValues;

    public int HazardCount;
    public float SpawnWait;
    public float StartWait;
    public float WaveWait;

    private bool _gameOver;
    private bool _start;

    public void Start()
    {
    }

    public IEnumerator SpawnWaves()
    {
        AudioSource.PlayClipAtPoint(audioClip, Vector3.zero);
        yield return new WaitForSeconds(StartWait);
        music.Play();
        while (true)
        {
            for (int i = 0; i < HazardCount; i++)
            {
                Debug.Log(i);
                if (i == 8)
                {
                    GameObject hazard = Hazards[0];

                    Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    Quaternion spawnRotation = Quaternion.Euler(
                        Quaternion.identity.eulerAngles.x - 90,
                        Quaternion.identity.eulerAngles.y,
                        Quaternion.identity.eulerAngles.z);
                    Instantiate(hazard, spawnPosition, spawnRotation);
                    yield return new WaitForSeconds(SpawnWait);
                }
                else
                {
                    GameObject hazard = Hazards[Random.Range(1, Hazards.Length)];

                    Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    Quaternion spawnRotation = Quaternion.Euler(
                        Quaternion.identity.eulerAngles.x - 90,
                        Quaternion.identity.eulerAngles.y,
                        Quaternion.identity.eulerAngles.z);
                    Instantiate(hazard, spawnPosition, spawnRotation);
                    yield return new WaitForSeconds(SpawnWait);
                }
            }
            yield return new WaitForSeconds(WaveWait);

            if (_gameOver)
            {
                break;
            }
        }
    }

    public void Update()
    {
        if(_start)
            return;

        if (GamePad.GetButtonDown(GamePad.Button.A, GamePad.Index.Any))
            StartCoroutine(SpawnWaves());

    }

    public void GameOver()
    {
        _gameOver = true;
    }
}
