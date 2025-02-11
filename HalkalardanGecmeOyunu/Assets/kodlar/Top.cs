using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Top : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject EfektPrefab;
    public float jumpForce;
    private GameManager gm;

    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();

        if (gm == null)
        {
            Debug.LogError("GameManager bulunamadý! GameManager script'i sahnede mi?");
        }
    }

    void Update()
    {
    }

    private void OnCollisionEnter(Collision other)
    {
       
        rb.AddForce(Vector3.up * jumpForce);

        
        GameObject Efekt = Instantiate(EfektPrefab, transform.position + new Vector3(0f, -0.2f, 0f), transform.rotation);
        Efekt.transform.SetParent(other.gameObject.transform);

        
        string metarialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Materyal Ýsmi :" + metarialName);

        
        if (metarialName == "GuvensizAlan (Instance)")
        {
            if (gm != null)
            {
                gm.RestartGame();
            }
            else
            {
                Debug.LogError("GameManager null, sahne yeniden baþlatýlamadý.");
            }
        }
        else if (metarialName == "SonHalka (Instance)")
        {
            gm.Leveliki();
        }
    }
}
