using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Star : MonoBehaviour
{
    public static int pumpkin;
    public GameObject text;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "pumpkin")
        {
           text.SetActive(true);
          //  Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
