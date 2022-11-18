using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private Text coinCounter;

    private int coinAmount;
    // Start is called before the first frame update  
    void Start()
    {
        coinAmount = 0;
    }

    

    // Update is called once per frame  
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            this.transform.Rotate(Vector3.left * 125f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            this.transform.Rotate(Vector3.left * -125f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            
            this.transform.position += transform.up * Time.deltaTime * 5.0f;
            this.GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * Time.deltaTime * 5f);

        }

        coinCounter.text = "Coins: " + coinAmount;


    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Coin>())
        {
            coinAmount++;
            Destroy(collision.gameObject);
        }
    }
}