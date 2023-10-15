using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform target; // Player's Transform

    public float rotationSpeed = 5.0f;

    public Vector3 offset;

    private float mouseX;
    private float mouseY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // by the time this method is called, the target has done all of its movement
    private void LateUpdate()
    {

    }

    private void FixedUpdate()
    {

        offset = new Vector3(0.0f, 1.0f, 0.0f);

        if(transform.rotation.x >= 90 && transform.rotation.x <=270)
        {
            offset.x = 4.0f;
        }
        else
        {
            offset.x = -4.0f;
        }

        if (transform.rotation.z >= 90 && transform.rotation.z <= 270)
        {
            offset.z = 4.0f;
        }
        else
        {
            offset.z = -4.0f;
        }

        transform.position = target.position + offset;

        // Get mouse input
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY += Input.GetAxis("Mouse Y") * rotationSpeed;

        // Rotate the camera based on mouse input
        Quaternion cameraRotation = Quaternion.Euler(0f, mouseX, 0f);
        transform.rotation = cameraRotation;

        // Rotate the player based on mouse input (optional)
        target.rotation = Quaternion.Euler(0f, mouseX, 0f);

    }
}