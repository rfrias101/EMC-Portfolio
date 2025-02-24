using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSpriteDisplay : MonoBehaviour
{
    public Image characterImage; 

    public Sprite caelusSprite;
    public Sprite march7thSprite;
    public Sprite danHengSprite;
    public Sprite weltYangSprite;
    public Sprite himekoSprite;
    public Sprite silverWolfSprite;
    public Sprite kafkaSprite;
    public Sprite defaultSprite;

    void Start()
    {
        characterImage.sprite = defaultSprite;
    }

    public void UpdateCharacterSprite(Characters character) 
    {
        //Will display the assigned character sprites based on the character count.
        if (character.charCount == 1)
        {
            characterImage.sprite = caelusSprite;
        }
        else if (character.charCount == 2)
        {
            characterImage.sprite = march7thSprite;
        }
        else if (character.charCount == 3)
        {
            characterImage.sprite = danHengSprite;
        }
        else if (character.charCount == 4)
        {
            characterImage.sprite = weltYangSprite;
        }
        else if (character.charCount == 5)
        {
            characterImage.sprite = himekoSprite;
        }
        else if (character.charCount == 6)
        {
            characterImage.sprite = silverWolfSprite;
        }
        else if (character.charCount == 7)
        {
            characterImage.sprite = kafkaSprite;
        }
        else
        {
            Debug.Log("No matching sprite for Character #" + character.charCount);
            characterImage.sprite = defaultSprite;
        }
    }
}
