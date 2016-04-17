using UnityEngine;
using System.Collections;

public class Bonus : MonoBehaviour
{

    private bool _triggered;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bonus" && !_triggered)
        {
            _triggered = true;
            gameObject.SetActive(false);
        }
    }
}
