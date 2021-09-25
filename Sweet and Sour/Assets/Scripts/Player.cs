using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed;
    public int health = 5;
    public int points;
    public HealthBar healthBar;

    public Text pointsDisplay;
    public Text healthDisplay;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //healthBar.SetMaxHealth(health);
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        healthDisplay.text = "Health: " + health;
        healthBar.PlayerHealth(health);

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

}
