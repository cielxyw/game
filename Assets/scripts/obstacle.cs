using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    Vector2 startPos;
    // Start is called before the first frame update
    private void Start()
    {
        startPos = transform.position;  
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
     if (collision.CompareTag("Obstacle"))
        {
            Die();
        }
    }

    public void Die()
    {
        StartCoroutine(Respawn(0.5f));
    }

    IEnumerator Respawn(float duration)
    {
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
