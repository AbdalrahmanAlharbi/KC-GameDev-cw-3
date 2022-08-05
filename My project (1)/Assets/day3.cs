using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{
    string heroname = "ُEzio";
    string villianname = "Mohammed";
    int heropower = 60;
    int villianpower = 40;

    float playerspeed = 9.11f;
    


    // Start is called before the first frame update
    void Start()
    {
        if (villianpower < heropower)
        {
            print("hero will win");
        }
        else if (heropower == villianpower)
        {
            print("no one will win");
        }
        else
        {
           print (heropower);
        }
        print (playerspeed);
        setspeed(2.5f);
        print(playerspeed);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void setspeed(float speed)
    {
        playerspeed = speed;
    }

} 

    

