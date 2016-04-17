﻿using UnityEngine;
using System.Collections;

public class Hold : MonoBehaviour
{
    public Transform cameraPosition;

    void LateUpdate()
    {
         transform.rotation = Quaternion.Euler(new Vector3((int)cameraPosition.eulerAngles.x, (int)cameraPosition.eulerAngles.y, (int)cameraPosition.eulerAngles.z - 90));
    }
}
