using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public Transform Top;
    private Vector3 offset;
    public float smoothspeed;


    void Start()
    {
        offset = transform.position -  Top.position;
    }

 
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + Top.position , smoothspeed);
        transform.position = newPos;
    }
}
