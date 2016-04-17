using UnityEngine;
using System.Collections;
using System.Runtime.Serialization;
using ObjectManager = System.Runtime.Serialization.ObjectManager;

public class SetActiveOnContact : MonoBehaviour
{
    private IEnumerator timerCorutine;
    private AddWalls addwalls;

    void Start()
    {
        addwalls = GetComponent<AddWalls>();
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
            StartCoroutine(WaitTime());
        }
    }
    public IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(0.25f);
        OwnObjectManager.Instance.Walls[addwalls.wallindex][1].SetActive(false);
        OwnObjectManager.Instance.Walls[addwalls.wallindex][2].SetActive(true);
        OwnObjectManager.Instance.Walls[addwalls.wallindex][3].SetActive(true);
    }
}