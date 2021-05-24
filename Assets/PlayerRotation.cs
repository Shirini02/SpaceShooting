using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("WELCOME TO THE GAME");
        print("Space ship can move to the left and right side");
        print("On perfectly destroying asteroids score will be increased");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward);
        }


        //float xAxis = Input.GetAxis("Mouse X");
        //float yAxis = Input.GetAxis("Mouse Y");
        //transform.rotation = Quaternion.Euler(0, xAxis, 0) * transform.rotation;
        //Camera cam = GetComponentInChildren<Camera>();
        //cam.transform.localRotation = Quaternion.Euler(-yAxis, 0, 0) * cam.transform.localRotation;/*
    }
    
}
