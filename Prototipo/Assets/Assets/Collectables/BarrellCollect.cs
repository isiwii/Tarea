using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrellCollect : MonoBehaviour
{
    public int barrells;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Barrell")
        {
            Debug.Log("Barrell Collected");
            barrells = barrells + 1;
           // Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
