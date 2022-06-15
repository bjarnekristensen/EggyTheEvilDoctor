using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggPoint : MonoBehaviour
{
    public float minSpeed = 4f;
    public float maxSpeed = 8f;
    public float angleVariation = 15f;
    float speed;
    Player playerScript;
    Transform headTransform;
    public int score = 1;
    bool isFading = false;
    [Tooltip("Time for the object to fade out and destroy after hitting the ground.")]
    public float fadeTime = 0.5f;
    float fadeTimer = 0f;
    public float maxLiveTime = 10f;
    float liveTimer;
    public GameObject groundSplash;
    public GameObject playerHitSplash;
    BoxCollider2D boxCollider2D;
    SpriteRenderer[] spriteRenderers;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        headTransform = playerScript.transform.Find("eggy-body").Find("eggy-head-idle");
        boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        spriteRenderers = gameObject.GetComponentsInChildren<SpriteRenderer>();
        float randomAngle = Random.Range(0f - angleVariation, angleVariation);
        transform.Rotate(0f, 0f, randomAngle);
        liveTimer = maxLiveTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        liveTimer -= Time.deltaTime;
        if (liveTimer <= 0f)
            Destroy(gameObject);

        if (isFading)
        {
            if (fadeTimer <= 0)
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
            fadeTimer -= Time.deltaTime;
            for (int i = 0; i < spriteRenderers.Length; i++)
            {
                Color tempColor = spriteRenderers[i].color;
                tempColor.a = fadeTimer / fadeTime;
                spriteRenderers[i].color = tempColor;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerScript.GetPoint(score);
            Instantiate(playerHitSplash, headTransform.position, Quaternion.identity);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

        if (collision.tag == "Ground")
        {
            Instantiate(groundSplash, transform.position + new Vector3(0f, -0.5f), Quaternion.identity);
            boxCollider2D.enabled = false;
            fadeTimer = fadeTime;
            isFading = true;
            speed = 0;
        }
    }
}
