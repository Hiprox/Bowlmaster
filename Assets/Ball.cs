using JetBrains.Rider.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 launchVelocity;
    private Rigidbody rigidBody;
    private AudioSource audioSource;
    
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = launchVelocity;

        Launch();
    }

    public void Launch()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    void Update()
    {
        
    }
}
