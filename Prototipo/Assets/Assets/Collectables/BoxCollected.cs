using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollected : MonoBehaviour
{
    public static int Boxes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

  void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Box")
        {
            Boxes = Boxes + 1;
          //  Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
