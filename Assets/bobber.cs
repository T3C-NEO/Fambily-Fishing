using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobber : MonoBehaviour
{
    public GameObject wall;

    public GameObject bob;
    public GameObject bobZoom;

    public float bobbingHeight = 0.5f; // Adjust this value to set the bobbing height
    public float bobbingSpeed = 2.0f; // Adjust this value to set the bobbing speed

    private bool isBobbing = false;
    private float bobbingDuration;

    private bool catching = false;
    private bool waiting = false;

    private int catchin;
    private int timer;


    public float moveSpeed = 2.0f;


    private Vector3 initialPosition;

    void FixedUpdate()
    {
        if (catching == false)
        {
            timer += 1;
            if (catchin >= 1200 && !isBobbing)
            {
                catchin = 0;
                StartBobbing();
            }

            if (isBobbing)
            {
                BobObject();
            }
            else
            {
                catchin = Mathf.RoundToInt(Random.Range(1, 1080) + timer);
            }

            if (Input.GetMouseButtonDown(0) && isBobbing)
            {
                bobbingDuration = 0;
                bobZoom.transform.position = bob.transform.position;
                isBobbing = false;
                wall.transform.position = initialPosition;
                catching = true;
                timer = 0;
            }
        }

        if (catching == true)
        {
            bobZoom.transform.position = Vector2.Lerp(bobZoom.transform.position, new Vector2(-2.74f, 2.57f), moveSpeed * Time.deltaTime);
        }

        if (bobZoom.transform.position.x < -2.73)
        {
            Debug.Log("help");
            catching = false;
            waiting = true;
            bobZoom.transform.position = new Vector3(0, 0, -4);
        }

        if (waiting == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                catching = false;
                waiting = false;
            }
        }
    }

    void StartBobbing()
    {

        initialPosition = wall.transform.position;
        bobbingDuration = Random.Range(2.0f, 5.0f);
        isBobbing = true;
    }

    void BobObject()
    {
        float yPosition = initialPosition.y + Mathf.Sin(Time.time * bobbingSpeed) * bobbingHeight;
        wall.transform.position = new Vector3(wall.transform.position.x, yPosition, wall.transform.position.z);

        bobbingDuration -= Time.deltaTime;

        if (bobbingDuration <= 0)
        {
            wall.transform.position = initialPosition;
            timer = 0;
            isBobbing = false;

        }
    }
}
