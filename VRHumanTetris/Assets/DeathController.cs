using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    private bool triggered;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !triggered)
        {
            triggered = true;
            StartCoroutine(StartDeath());
        }
    }

    public IEnumerator StartDeath()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("GameOver");
    }
}
