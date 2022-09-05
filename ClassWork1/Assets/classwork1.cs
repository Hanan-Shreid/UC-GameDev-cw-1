using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classwork1 : MonoBehaviour
{
    string heroName= "Mario";
    float heroHeihgt = 15.4f;
    int heroAge = 22;
    string heroSuperpower  = "Super power" ;

    string vallainName = "Nike";
    float villainHeight = 16.7f;
    int vallainAge = 27;
    string vallainSuperPower = " vallain super power";

    

    // Start is called before the first frame update
    void Start()
    {

        int ageDiff = vallainAge - heroAge;

        print("My hero "+heroName);
        print(heroAge);
        print(heroHeihgt);
        print(heroSuperpower);
        print(vallainName);
        print(vallainAge);
        print(villainHeight);
        print(vallainSuperPower);
        print(ageDiff);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
