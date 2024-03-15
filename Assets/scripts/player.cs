using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class player : MonoBehaviour
{
    public static player instance;
    
    public float playerMoveSpeed;
    public Rigidbody2D playerRB;
    public Collider2D playerColl;
    public float aniTriValue = 0.01f;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        playerColl = GetComponent<Collider2D>();
        playerRB = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        Perspective();
    }

    void Perspective()//-4.3 ~ 4 1~0.5
    {
        float y = transform.position.y;
        float scale = 1 - (y + 4.3f)/8.3f * 0.5f;
        transform.localScale = new Vector3(scale, scale, 1);
    }

    void PlayerMove()
    {
        float verticalNum = Input.GetAxis("Vertical");
        playerRB.velocity = new Vector2(playerRB.velocity.x, playerMoveSpeed * verticalNum);
        var animator = GetComponentInChildren<Animator>();
        if(math.abs(verticalNum) > aniTriValue)
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
}
