using System.Collections;
using UnityEngine;

public class SmoothSpriteMovement : MonoBehaviour
{
    float minX = -10f;
    float maxX = 14f;
    float minY = -6f;
    float maxY = -1.7f;
    float moveSpeed = 1.5f;

    public Sprite[] spriteList; // Array of sprites
    float[] spriteProbabilities = { 0.35f, 0.25f, 0.2f, 0.15f, 0.05f }; // Probabilities for each sprite

    private Vector3 targetPosition;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(MoveRandomly());
    }

    void Update()
    {
        MoveTowardsTarget();
    }

    IEnumerator MoveRandomly()
    {
        while (true)
        {
            ChooseRandomTargetPosition();
            FlipSpriteDirection();
            CheckAndChangeSprite();
            yield return new WaitForSeconds(Random.Range(5f, 10f));
        }
    }

    void ChooseRandomTargetPosition()
    {
        targetPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f);
    }

    void FlipSpriteDirection()
    {
        if (transform.position.x < targetPosition.x)
        {
            spriteRenderer.flipX = true; // Flip when moving right
        }
        else
        {
            spriteRenderer.flipX = false; // Flip when moving left
        }
    }

    void CheckAndChangeSprite()
    {
        // Check conditions and probabilities
        if (transform.position.x < -6f || transform.position.x > 9.5f || transform.position.y < -5.5f)
        {
            ChangeSpriteBasedOnProbability();
        }
    }

    void ChangeSpriteBasedOnProbability()
    {
        float randomValue = Random.value;
        float cumulativeProbability = 0f;

        // Iterate through sprite probabilities to determine which sprite to choose
        for (int i = 0; i < spriteProbabilities.Length; i++)
        {
            cumulativeProbability += spriteProbabilities[i];

            if (randomValue <= cumulativeProbability)
            {
                // Change sprite to the selected index from spriteList
                spriteRenderer.sprite = spriteList[i];
                break;
            }
        }
    }

    void MoveTowardsTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            StartCoroutine(MoveRandomly());
        }
    }
}
