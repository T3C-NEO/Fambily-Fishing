using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noFric : MonoBehaviour
{
    public Rigidbody2D rb;


    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = new Vector2(0, 0);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        rb.velocity = new Vector2(0, 0);

    }
}
