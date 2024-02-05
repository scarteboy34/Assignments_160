using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;

public class FtuitManager : MonoBehaviour
{

    public List<Fruit> fruitSalad;
    // Start is called before the first frame update
    void Start()
    {
        fruitSalad = new List<Fruit>();

        Fruit apple = new Fruit("apple", Color.black, 2.1f);

        fruitSalad.Add(apple);

        CreateFruitSalad();
        DisplayFruitSalad();

    // Update is called once per frame
    void Update()
    {
        
    }
}

    private void DisplayFruitSalad()
    {
for(int i = 0; i < fruitSalad.Count; i++)
        {
            print("Color" + fruitSalad[i].color.ToString() + "Name" + fruitSalad[i].name + "weghing" + fruitSalad[i].weight + "units");
        }
    }

    private void CreateFruitSalad()
    {
        fruitSalad.Add(new Fruit());

        fruitSalad.Add(new Fruit("strawberry"));

        fruitSalad.Add(new Fruit(Color.red));
    }
}
