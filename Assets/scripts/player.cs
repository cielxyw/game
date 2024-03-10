using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerMoveSpeed;
    public Rigidbody2D playerRB;
    public Collider2D playerColl;
    void Start()
    {
        playerColl = GetComponent<Collider2D>();
        playerRB = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove(); 
    }

    void PlayerMove()
    {
        float verticalNum = Input.GetAxis("Vertical");
        playerRB.velocity = new Vector2(playerRB.velocity.x, playerMoveSpeed * verticalNum);
    }
}
