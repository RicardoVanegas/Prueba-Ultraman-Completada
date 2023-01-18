using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayAttribute : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public Card card;
    public GameObject panel;
    public TMP_Text attribute;
    public Animator anim;
    public void OnPointerEnter(PointerEventData eventData)
    {
        anim.SetTrigger("hoverOn");
        //panel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        anim.SetTrigger("hoverOff");
       // panel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        attribute.text = card.attributeText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
