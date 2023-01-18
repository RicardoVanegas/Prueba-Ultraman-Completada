using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CardEvents : MonoBehaviour, IPointerClickHandler
{

    public Card card;
    public GameObject panelName;
    public TMP_Text cardName;
    public TMP_Text rarity;

    public GameObject panelAttribute;
    public TMP_Text attribute;


    public TMP_Text hp,
                    cost,
                    ATK;
    public GameObject panelHP;

    public SaveLoadData data;
    public AudioSource wav;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            panelName.SetActive(true);
            cardName.text = card.cardName;
            rarity.text = card.rarityText;
            attribute.text = card.attributeText;


            data.setName(card.cardName);
            wav.Play();
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            panelHP.SetActive(true);
            wav.Play();
            
            attribute.text = card.attributeText;
            hp.text = card.hp.ToString();
            cost.text = card.cost.ToString();
            ATK.text = card.atk.ToString();

        }
        
    }

    



    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {


        

    }
    
}
