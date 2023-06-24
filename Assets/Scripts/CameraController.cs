using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 cameraOffset;

    [SerializeField] private Transform target;
    // Start is called before the first frame update
    private float speed = 1.5f;
    public float number = 3.1f;
    
    private void Start()
    {
        Debug.Log("デバッグ");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.position + cameraOffset;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>();

        this.transform.position =  new Vector3(1, 1, 1);
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        throw new NotImplementedException();
    }

    private void OnCollisionExit(Collision other)
    {
        throw new NotImplementedException();
    }
}
