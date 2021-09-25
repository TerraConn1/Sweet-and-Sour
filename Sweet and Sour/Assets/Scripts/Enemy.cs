using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public float speed;
    private Transform playerPos;
    private Player player;
    public HealthBar healthBar;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.health--;
            Destroy(gameObject);
        }

        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }

}
