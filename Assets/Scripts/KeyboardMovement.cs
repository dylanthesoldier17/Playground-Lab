using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    public float speed = 5;
    private void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalMovement * speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalMovement * speed * Time.deltaTime);
    }
}
