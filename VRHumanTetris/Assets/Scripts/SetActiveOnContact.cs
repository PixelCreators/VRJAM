using UnityEngine;
using System.Collections;
using System.Runtime.Serialization;
using ObjectManager = System.Runtime.Serialization.ObjectManager;

public class SetActiveOnContact : MonoBehaviour
{
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Background" || other.gameObject.tag == "Boundary")
        {
            return;
        }
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Jestem w ifie");
            Debug.Log(other.gameObject.name);
            gameObject.SetActive(false);
            OwnObjectManager.Instance.LeftWall.SetActive(true);
            OwnObjectManager.Instance.RightWall.SetActive(true);
        }
    }
}