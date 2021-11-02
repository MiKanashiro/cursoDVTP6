using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;
    [SerializeField]
    private float rotationSpeed = 720;
    private AudioManager audioManager;
    float cameraAxis;
    

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Movement(horizontal, vertical);
        RotatePlayer();
    }

    void Movement(float horizontal, float vertical)
    {
        Vector3 movementDirection = new Vector3(horizontal, 0, vertical);
        transform.Translate(speed * movementDirection.normalized * Time.deltaTime, Space.World);
    }

    void RotatePlayer()
    {
        cameraAxis += Input.GetAxis("Mouse X");
        Quaternion angulo = Quaternion.Euler( 0, cameraAxis, 0);
        transform.localRotation = angulo;
    }
    
}
