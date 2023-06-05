using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Ball ball;
    public float headpin = 1829f;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - ball.gameObject.transform.position;
    }

    void Update()
    {
        if (transform.position.z <= headpin)
        {
            transform.position = ball.gameObject.transform.position + offset;
        }
    }
}
