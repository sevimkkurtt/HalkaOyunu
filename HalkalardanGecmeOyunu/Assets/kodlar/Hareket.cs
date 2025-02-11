using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float rotatespeed;
        private float moveX;

    void Update()
    {
        moveX = Input.GetAxis("Mouse X");
        
        if(Input.GetMouseButton(0))
        {
            transform.Rotate(0f, moveX * rotatespeed * Time.deltaTime, 0f);
        }
    }
}
