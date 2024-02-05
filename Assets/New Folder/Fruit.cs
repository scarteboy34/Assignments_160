using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit 
{

    public string name;
    public Color color;
    public float weight;


    public Fruit(string name , Color c, float w)
    {
       this.name = name;
        color = c;
        weight = w;
    }

    public Fruit()
    {
        name = "Orabge";
            color=Color.yellow;
            weight = 1.0f;
    }

    public Fruit(string n)
    {
        name = n;
        color = Color.blue;
        weight = 1.3f;
    }

    public Fruit(Color c)
    {
        name = "watermelon";
        color = c;
        weight = 5.8f;

        
    }

    ~Fruit()
    {
        name = null;
            color = Color.clear;
            weight = 0.0f;

    }

}
