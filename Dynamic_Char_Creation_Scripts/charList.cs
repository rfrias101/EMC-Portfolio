using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class charList : MonoBehaviour
{
    public List<Characters> characterList = new List<Characters>();

    public GameObject CardsPrefab;
    public Transform SpawnCards;

    public CharSpriteDisplay spriteDisplay;  //Displays the sprite for the 2nd panel

    [Header("Info")]
    public TextMeshProUGUI charName;
    public TextMeshProUGUI charDesc;
    public TextMeshProUGUI charGender;
    public TextMeshProUGUI charNum;
    public TextMeshProUGUI charElem;
    void Start()
    {
        Characters char0 = new Characters(); //Just testing simple oop
        char0.name = "Memcho";
        char0.description = "Pet";

        Characters char1 = new Characters("Caelus", "Main Char.", "Male", 1, Element.Physical);
        Characters char2 = new Characters("March 7th", "Cheerful", "Female", 2, Element.Ice);
        Characters char3 = new Characters("Dan Heng", "Quiet", "Male", 3, Element.Wind);
        Characters char4 = new Characters("Welt Yang", "Serious", "Male", 4, Element.Imaginary);
        Characters char5 = new Characters("Himeko", "Caring", "Female", 5, Element.Flame);
        Characters char6 = new Characters("Silver Wolf", "Hacker", "Female", 6, Element.Quantum);

        characterList.Add(char1);
        characterList.Add(char2);
        characterList.Add(char3);
        characterList.Add(char4);
        characterList.Add(char5);
        characterList.Add(char6);

        foreach (Characters c in characterList) // Spawns the buttons
        {
            Spawn(c);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn(Characters character)
    {
        GameObject spawnButton = Instantiate(CardsPrefab, SpawnCards); //UI spawn cards

        UICards uiCards = spawnButton.GetComponent<UICards>();

        Button button = spawnButton.GetComponent<Button>();

        uiCards.CardData(character);

        button.onClick.AddListener(() => CardsOnClick(character));
    }

    public void CardsOnClick(Characters character)
    {
        charName.text = character.name;
        charDesc.text = character.description;
        charGender.text = character.gender;
        charNum.text = character.charCount.ToString();
        charElem.text = character.element.ToString();

        if (spriteDisplay != null) //Char sprite display script
        {
            spriteDisplay.UpdateCharacterSprite(character);
        }
    }
}
    
[System.Serializable]
public class Characters
{
    public string name;
    public string description;
    public string gender;
    public int charCount;
    public Element element;

    public Characters()
    {
        name = "UNKNOWN";
        description = "UNKNOWN";
        gender = "UNKNOWN";
        charCount = 0;
        element = Element.UNKNOWN;
    }

    public Characters(string name, string description, string gender, int charCount, Element element)
    {
        this.name = name;
        this.description = description;
        this.gender = gender;
        this.charCount = charCount;
        this.element = element;
    }
}
public enum Element { Flame, Ice, Imaginary, Quantum, Wind, Physical, Electro, UNKNOWN };

