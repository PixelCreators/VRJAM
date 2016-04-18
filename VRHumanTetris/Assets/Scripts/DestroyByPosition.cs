using UnityEngine;

public class DestroyByPosition : MonoBehaviour
{
    public void Start()
    {
        
    }

    public void Update()
    {
        Debug.Log(gameObject.transform.position);
        if ((gameObject.transform.position.x > 6) || (gameObject.transform.position.x < -6) ||
            (gameObject.transform.position.y > 10) || (gameObject.transform.position.y < -5) ||
            (gameObject.transform.position.z > 25) || (gameObject.transform.position.z < -4))
        {
            Destroy(gameObject);
        }
    }
}
