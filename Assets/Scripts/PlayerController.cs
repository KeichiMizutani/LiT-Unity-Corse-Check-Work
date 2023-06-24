using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float jumpPower = 8.0f;
    private Rigidbody rigidbody;
    private Vector3 spawnPos;

    public int itemScore = 0;

    private int jumpCount = 0;

    private bool isJumping = false;

    [SerializeField] private Transform goalTransform;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text goalText;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        spawnPos = transform.position;
    }

    private void FixedUpdate()
    {
        // 移動
        rigidbody.velocity = new Vector3(
            Input.GetAxis("Horizontal") * speed
            , rigidbody.velocity.y
            , Input.GetAxis("Vertical") * speed
            );
    }

    private void Update()　　　
    {
        // ジャンプ
        
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (jumpCount < 2)
                {
                    rigidbody.AddForce(Vector3.up * jumpPower * rigidbody.mass * 50f); // <- 飛ぶ
                    jumpCount++;
                }
            }
        

        // リスポーン設定
        if (transform.position.y < -3f)
        {
            transform.position = spawnPos;
            rigidbody.velocity = Vector3.zero; // new Vector3(0,0,0)
            rigidbody.angularVelocity = Vector3.zero;
        }
        
        // UI表示
        scoreText.text = itemScore.ToString();
        goalText.text = Vector3.Magnitude(transform.position - goalTransform.position).ToString("f1");
    }

    private void OnCollisionEnter(Collision collision)
    {
        jumpCount = 0;
    }

    private void OnTriggerEnter(Collider other)
    {

        isJumping = false;
        
        Destroy(other.gameObject);

        itemScore++;
        Debug.Log(itemScore);
    }
}
