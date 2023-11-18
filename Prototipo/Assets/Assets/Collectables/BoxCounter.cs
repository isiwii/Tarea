using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BoxCounter : MonoBehaviour
{
    public TMP_Text text;
    public static int BoxAmount;

    
    // Start is called before the first frame update
    void Start ()
    {
        text = GetComponent<TMP_Text> ();
    }

    void Update ()
    {
      text.text = BoxCollected.Boxes.ToString();
    }
}
