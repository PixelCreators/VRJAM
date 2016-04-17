using UnityEngine;
using System.Collections;

public class SetActiveOnContact : MonoBehaviour
{
    private AddWalls _addwalls;

    public void Start()
    {
        _addwalls = gameObject.transform.parent.gameObject.GetComponent<AddWalls>();
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Background" || other.gameObject.tag == "Boundary")
        {
            return;
        }
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(WaitTime());
        }
    }
    public IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(0.25f);
        OwnObjectManager.Instance.Walls[_addwalls.Wallindex][1].SetActive(false);
        OwnObjectManager.Instance.Walls[_addwalls.Wallindex][2].SetActive(true);
        OwnObjectManager.Instance.Walls[_addwalls.Wallindex][3].SetActive(true);
    }
}