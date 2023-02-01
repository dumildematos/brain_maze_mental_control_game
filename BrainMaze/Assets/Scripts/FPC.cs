using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPC : MonoBehaviour
{

    public Transform player;
    public float mouseSensitivity = 2f;
    float camaraVerticalRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;


        camaraVerticalRotation -= inputY;

        camaraVerticalRotation = Mathf.Clamp(camaraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * camaraVerticalRotation;

        player.Rotate(Vector3.up * inputX);


    }
}
