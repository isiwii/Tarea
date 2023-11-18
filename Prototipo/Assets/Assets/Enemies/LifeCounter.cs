using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifeCounter : MonoBehaviour
{
    public TMP_Text text;
    public int health;
    
    
    // Start is called before the first frame update
    void Start ()
    {
        text = GetComponent<TMP_Text> ();
    }

    void Update ()
    {
      text.text = CharacterStatus.health.ToString();
    }
}
