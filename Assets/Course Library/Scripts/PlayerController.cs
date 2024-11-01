using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20.0f;
    private const float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward        
        // Will move a unit per frame call. If 60fps car will move 60 units.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Turn vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
