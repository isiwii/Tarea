using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollected : MonoBehaviour
{
    public static int coins;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
            coins = coins + 1;
          //  Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
