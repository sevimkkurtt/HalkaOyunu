using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halka : MonoBehaviour
{
    public Transform Top;

    private GameManager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y + 12.5f >= Top.position.y)
        {
            Destroy(gameObject);
            gm.gameScore(25);
        }
    }
}
