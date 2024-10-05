using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Adds a "Monster" option to the program
[CreateAssetMenu(fileName="Monster", menuName = "Create new Monster")]

//creates class used to create character objects
public class MonBase : ScriptableObject
{
    //initialises all the necessary variables
    [SerializeField] string monName;

    [TextArea]
    [SerializeField] string monDescription;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] monsterType type1;
    [SerializeField] monsterType type2;

    [SerializeField] int hp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spatk;
    [SerializeField] int spdef;
    [SerializeField] int speed;

    //Properties used to access the data stored in each variable
    public string MonName{
        get{ return monName;}
    }
    
    public string MonDescription{
        get{ return monDescription;}
    }

    public Sprite FrontSprite{
        get{ return frontSprite;}
    }

    public Sprite BackSprite{
        get{ return backSprite;}
    }

    public monsterType Type1{
        get{ return type1;}
    }

    public monsterType Type2{
        get{ return type2;}
    }

    public int HP{
        get{ return hp;}
    }

    public int Attack{
        get{ return attack;}
    }

    public int Defense{
        get{ return defense;}
    }

    public int SpAtk{
        get{ return spatk;}
    }

    public int SpDef{
        get{ return spdef;}
    }

    public int Speed{
        get{ return speed;}
    }




}

public enum monsterType
{
    None,
    Normal,
    Fire,
    Fighing,
    Water,
    Flying,
    Grass,
    Poison,
    Electric,
    Ground,
    Psychic,
    Rock,
    Ice,
    Bug,
    Dragon,
    Ghost,
    Dark,
    Steel,
    Fairy
}