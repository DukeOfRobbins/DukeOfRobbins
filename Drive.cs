using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 20.0f;
    public float rotationSpeed = 1.0f;
    public float currentSpeed = 0;
    public float translation;
    public float rotation;

    // Update is called once per frame
    void Update()
    {
        translation = Input.GetAxisRaw("Vertical") * speed;
        rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        currentSpeed = translation;

        transform.Rotate(0, rotation, 0);
    }
}
