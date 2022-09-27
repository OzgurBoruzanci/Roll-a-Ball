using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ball;
    Vector3 distanceBerween;
    void Start()
    {
        distanceBerween = transform.position - ball.transform.position;

    }


    void LateUpdate()
    {
        transform.position = ball.transform.position + distanceBerween;
    }
}
