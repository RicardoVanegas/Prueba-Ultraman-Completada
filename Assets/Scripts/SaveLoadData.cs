using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveLoadData : MonoBehaviour
{
    public GameObject panel;
    public TMP_Text card;
    // Start is called before the first frame update
    void Start()
    {
        card.text=PlayerPrefs.GetString("cardName");

        if (PlayerPrefs.GetString("cardName").Equals(null))
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setName(string cardName)
    {
        PlayerPrefs.SetString("cardName", cardName);
    }
}
