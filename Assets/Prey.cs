using UnityEngine;
using System;
using System.Collections.Generic;

public class Prey : Animal
{
    public static List<Prey> allPrey;

    public Prey(int s){
        allPrey.Add(this);
        skill = s;
    }
}
