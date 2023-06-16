using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ball))]
public class DragLaunch : MonoBehaviour
{
    private Vector3 dragStart, dragEnd;
    private float startTime, endTime;
    private Ball ball;
    void Start()
    {
        ball = GetComponent<Ball>();
    }

    public void DragStart()
    {
        startTime = Time.time;
        dragStart = Input.mousePosition;
    }

    public void DragEnd()
    {
        endTime = Time.time;
        dragEnd = Input.mousePosition;

        float dragDuration = endTime - startTime;
        float launchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;
        float launchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;

        var launchVelocuty = new Vector3(launchSpeedX, 0, launchSpeedZ);
        ball.Launch(launchVelocuty);
    }

    public void MoveStart(float amount)
    {
        if (!ball.IsInPlay)
        {
            transform.Translate(new Vector3(amount, 0, 0));
        }
    }
}