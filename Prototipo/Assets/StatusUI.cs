/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusUI : MonoBehaviour
{
    public Image healBackground;
    public healthText;

    private CharacterStatus status;
    
    // Start is called before the first frame update
    void Start()
    {
        StatusUI = FindObjectOfType<CharacterStatus>();
    }

    // Update is called once per frame
    void Update()
    {
       Actualize(status.health, status.maxHealth);
    }

    public void Actualize(int value, int maxValue)
    {
        healthText.text = value.ToString;

        healBackground.fillAmount = (float)value / maxValue;
    }
}
*/