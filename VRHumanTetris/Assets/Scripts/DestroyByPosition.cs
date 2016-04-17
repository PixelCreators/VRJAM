using UnityEngine;

public class DestroyByPosition : MonoBehaviour
{
    public void Start()
    {
        
    }

    public void Update()
    {
        if ((gameObject.transform.position.x > 10) || (gameObject.transform.position.x < -10) ||
            (gameObject.transform.position.y > 8) || (gameObject.transform.position.y < -8) ||
            (gameObject.transform.position.z > 20.5) || (gameObject.transform.position.z < -10.5))
        {
            Destroy(gameObject);
        }
    }
}
