using UnityEngine;
using System.Collections;

public class AddPoints : MonoBehaviour
{
    public AudioClip audio;
    public bool triggered;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (other.tag == "Player" && !triggered)
        {
            triggered = true;
            AudioSource.PlayClipAtPoint(audio,Vector3.zero);
            PointsManager.AddPoints();
        }
    }
}
