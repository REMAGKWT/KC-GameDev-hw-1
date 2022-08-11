using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework1 : MonoBehaviour
{
    string heroname = "steve";

    int herohealth = 100;
    int damagedhealth;
    int boostedhealth;


    // Start is called before the first frame update
    void Start()
    {
        print(herohealth);

        damagedhealth = damaged();
        print(damagedhealth);

        boostedhealth = boost();
        print(boostedhealth);

        damaged();
        boost();
        comparespeed();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    int damaged()
    {
        return herohealth - 20;

    }

    int boost()
    {
        return damagedhealth + 10;


    }

    void comparespeed()
    {
        if (boostedhealth > damagedhealth)
        {
            print (boostedhealth + " is more than " + damagedhealth);

        }
            

    }




}
