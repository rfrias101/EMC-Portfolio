using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UICards : MonoBehaviour
{
    public charList charlist;
    public Image designHolder;
    public TextMeshProUGUI name;

    public Sprite flamebg;
    public Sprite icebg;
    public Sprite windbg;
    public Sprite quantumbg;
    public Sprite imaginarybg;
    public Sprite physicalbg;
    public Sprite electrobg;
    public Sprite defaultbg;
    public void CardData(Characters characters)
    {
        name.text = characters.name;

        if (designHolder == null)
        {
            Debug.Log("designHolder is not assigned!");
            return;
        }
        //UI buttons will change based on element classification
        if (characters.element == Element.Flame)
        {
            designHolder.sprite = flamebg;
        }

        else if (characters.element == Element.Ice)
        {
            designHolder.sprite = icebg;
        }
        
        else if (characters.element == Element.Wind)
        {
            designHolder.sprite = windbg;
        }

        else if (characters.element == Element.Quantum)
        {
            designHolder.sprite = quantumbg;
        }

        else if (characters.element == Element.Imaginary)
        {
            designHolder.sprite = imaginarybg;
        }

        else if (characters.element == Element.Physical)
        {
            designHolder.sprite = physicalbg;
        }
        else if (characters.element == Element.Electro)
        {
            designHolder.sprite = electrobg;
        }
        else
        {
            designHolder.sprite = defaultbg;
        }

    }

    void Awake()
    {
        designHolder = GetComponent<Image>();  // Assign the Image component to gameobj.
    }
}
