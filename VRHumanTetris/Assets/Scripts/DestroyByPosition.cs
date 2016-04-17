using UnityEngine;

public class DestroyByPosition : MonoBehaviour
{
    public void Start()
    {
        
    }

    public void Update()
    {
        if ((gameObject.transform.position.x > 40) || (gameObject.transform.position.x < -30) ||
            (gameObject.transform.position.y > 20) || (gameObject.transform.position.y < -20) ||
            (gameObject.transform.position.z > 50.5) || (gameObject.transform.position.z < -20.5))
        {
            Destroy(gameObject);
        }
    }
}
