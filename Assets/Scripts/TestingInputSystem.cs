using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingInputSystem : MonoBehaviour
{
    private Rigidbody sphereRigidbody;

    private void Awake()
    {
        sphereRigidbody = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        Debug.Log("Jump");
        sphereRigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }
}
