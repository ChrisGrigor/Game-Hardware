using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{


    public float mouseSenseVert = 100f;
    public float mouseSenseHorizontal = 300f;

    public Transform playerBody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {

        //Confine cursor to screen (helpful when more than 1 monitor, and in game)
        //will need a way to toggle this off when in like a menu
        Cursor.lockState = CursorLockMode.Confined;

        //Lock cursor
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSenseHorizontal * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSenseVert * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
