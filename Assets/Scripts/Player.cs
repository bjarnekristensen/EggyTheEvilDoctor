using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // UI
    //public Text healthDisplay;
    public GameObject losePanel;
    public NumberTicker healthFirstDigit;
    public NumberTicker scoreFirstDigit;
    public NumberTicker scoreSecondDigit;
    public NumberTicker scoreThirdDigit;

    // Player
    float input = 0;
    Rigidbody2D rigidBody2D;
    public float speed = 10;
    Animator animator;
    public int health = 3;
    public int score = 0;
    AudioSource audioExtraHealth;
    public int extraLifeAmount = 100;
    private int extraLifeCounter = 0;

    // Player abilities
    public float startDashTime = 0.1f;
    float dashTime;
    public float extraSpeed = 30f;
    bool isDashing = false;

    // Hit flash and immunity
    Material originalMaterial;
    [Tooltip("Material to switch to during the flash.")]
    public Material flashMaterial;
    [Tooltip("Duration of the flash.")]
    public float flashDuration = 0.2f;
    float flashTimer = 0;
    SpriteRenderer[] spriteRenderers;
    public float immunityDuration = 0.5f;
    internal float immunityTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioExtraHealth = GetComponent<AudioSource>();

        spriteRenderers = gameObject.GetComponentsInChildren<SpriteRenderer>();
        originalMaterial = spriteRenderers[0].material;

        UpdateHealthDisplay();
        UpdateScoreDisplay();
    }

    // Update is called once per frame
    private void Update()
    {
        if (input != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (input > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (input < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isDashing)
        {
            speed += extraSpeed;
            isDashing = true;
            dashTime = startDashTime;
        }

        if (dashTime <= 0 && isDashing)
        {
            isDashing = false;
            speed -= extraSpeed;
        }
        else
        {
            dashTime -= Time.deltaTime;
        }

        if (immunityTimer > 0)
        {
            immunityTimer -= Time.deltaTime;
        }

        if (flashTimer > 0)
        {
            flashTimer -= Time.deltaTime;
        }
        else
        {
            for (int i = 0; i < spriteRenderers.Length; i++)
            {
                spriteRenderers[i].material = originalMaterial;
            }
        }
    }

    // FixedUpdate is called at a fixed interval
    void FixedUpdate()
    {
        input = Input.GetAxisRaw("Horizontal");
        rigidBody2D.velocity = new Vector2(input * speed, rigidBody2D.velocity.y);
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0)
            health = 0;

        UpdateHealthDisplay();

        immunityTimer = immunityDuration;

        flashTimer = flashDuration;
        for (int i = 0; i < spriteRenderers.Length; i++)
        {
            spriteRenderers[i].material = flashMaterial;
        }

        if (health <= 0)
        {
            // Show lose screen
            losePanel.SetActive(true);

            // Destroy player
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    public void GetPoint(int scoreAmount)
    {
        score += scoreAmount;
        extraLifeCounter += scoreAmount;

        if (extraLifeCounter >= extraLifeAmount)
        {
            extraLifeCounter -= extraLifeAmount;
            health += 1;
            audioExtraHealth.Play();
            UpdateHealthDisplay();
        }

        UpdateScoreDisplay();
    }

    public void UpdateHealthDisplay()
    {
        healthFirstDigit.Digit = health;
    }

    public void UpdateScoreDisplay()
    {
        if (score < 10)
        {
            scoreFirstDigit.Digit = score;
            scoreSecondDigit.Digit = 0;
            scoreThirdDigit.Digit = 0;
        }
        else if (score < 100)
        {
            int result1;
            System.Int32.TryParse(score.ToString()[1].ToString(), out result1);
            scoreFirstDigit.Digit = result1;

            int result2;
            System.Int32.TryParse(score.ToString()[0].ToString(), out result2);
            scoreSecondDigit.Digit = result2;

            scoreThirdDigit.Digit = 0;
        }
        else if (score < 1000)
        {
            int result1;
            System.Int32.TryParse(score.ToString()[2].ToString(), out result1);
            scoreFirstDigit.Digit = result1;

            int result2;
            System.Int32.TryParse(score.ToString()[1].ToString(), out result2);
            scoreSecondDigit.Digit = result2;

            int result3;
            System.Int32.TryParse(score.ToString()[0].ToString(), out result3);
            scoreThirdDigit.Digit = result3;
        }
        else
        {
            scoreFirstDigit.Digit = 9;
            scoreSecondDigit.Digit = 9;
            scoreThirdDigit.Digit = 9;
        }
    }
}
