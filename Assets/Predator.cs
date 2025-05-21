using UnityEngine;
using System;
using System.Collections.Generic;

public class Predator : Animal
{
    public static List<Predator> allPredators;
    private int birthGen;


    public Predator(int s)
    {
        allPredators.Add(this);
        skill = s;
        birthGen = Main.gen;
    }
}
