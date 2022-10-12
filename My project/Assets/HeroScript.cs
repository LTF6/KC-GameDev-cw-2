using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour
{
    // Start is called before the first frame update

    double heroHeight = 1.9;
    int heroAge = 35;
    string heroSuperPower = "Nerd";


    double vililanHeight = 1.33;
    int villainAge = 65;
    string villainSuperPower = "Super Extra Nerd";

   

    void Start()
    {
        
        int addYearsOld = heroAge+5;
        print("i am a hero and iam " + " " + heroAge + "years old" + "but now i am " + " " + addYearsOld + "years old");
        print(addYearsOld);

        string villainSuperPowerIsNone = "none";
        print("My super power is" + villainSuperPower + "but now i changed it to" + " " + "none");

        int ageDifference = villainAge - heroAge;
        print("I am a Hero i am " + heroAge + "My super power is" + heroSuperPower + "iam " + heroHeight + "cm");
        print("I am a Villain i am " + villainAge + "My super power is" + villainSuperPower + "iam " + vililanHeight + "cm" + "i am older than the hero " + ageDifference + "years old");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
