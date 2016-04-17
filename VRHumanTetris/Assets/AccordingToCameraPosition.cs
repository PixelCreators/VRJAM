using UnityEngine;
using System.Collections;

public class AccordingToCameraPosition : MonoBehaviour
{

    public Transform cameraPosition;
    public Vector3 offset;

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    

    void FixedUpdate()
    {
        transform.position = new Vector3(cameraPosition.position.x + offset.x, transform.position.y, cameraPosition.position.z + offset.z);

        animator.SetFloat("Blend",cameraPosition.position.y*-1);
    }
}
