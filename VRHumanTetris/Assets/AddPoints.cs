using UnityEngine;
using System.Collections;

public class AddPoints : MonoBehaviour
{

    public bool triggered;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (other.tag == "Player" && !triggered)
        {
            triggered = true;
            PointsManager.AddPoints();
        }
    }
}
