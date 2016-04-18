using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByBoundary : MonoBehaviour {
    public void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
