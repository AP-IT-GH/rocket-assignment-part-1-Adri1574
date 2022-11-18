using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congratulations : MonoBehaviour
{
    public GameObject congratulations;

    void Start()
    {
        congratulations.SetActive(false);
    }

    void Update()
    {
        
    }
    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            congratulations.SetActive(true);


    }
}
