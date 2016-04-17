using UnityEngine;
using System.Collections;

public class AccordingToCameraPosition : MonoBehaviour
{
    public Transform cameraPosition;
    public Vector3 offset;

    void FixedUpdate()
    {
        transform.position = new Vector3(cameraPosition.position.x + offset.x, transform.position.y, transform.position.z);
    }
}
