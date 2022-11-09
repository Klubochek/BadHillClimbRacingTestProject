using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] public Transform cameraTransform, carBodyTransform;

    public void Update()
    {
        Vector3 vector3 = new Vector3(carBodyTransform.position.x, carBodyTransform.position.y, -10);
        cameraTransform.position = vector3;
    }
}
