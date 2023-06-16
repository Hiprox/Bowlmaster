using JetBrains.Rider.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool IsInPlay { get; private set; } = false;
    public Vector3 launchVelocity;
    private Rigidbody rigidBody;
    private AudioSource audioSource;
    
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    public void Launch(Vector3 velocity)
    {
        IsInPlay = true;
        rigidBody.useGravity = true;

        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        rigidBody.velocity = velocity;
    }

    void Update()
    {
        
    }
}
