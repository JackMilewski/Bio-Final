using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.Rendering;
public class Habitat
{
    public List<Prey> habitatPrey;
    public List<Predator> habitatPredators;

    public void Simulate()
    {
        bool flag = true;

        while (flag) {

            flag = false;

            while (habitatPrey.Count != 0 && habitatPredators.Count != 0)
            {
                if (habitatPrey[0].getSkill() < habitatPredators[0].getSkill())
                {
                    habitatPredators.Add(new Predator(habitatPredators[0].getSkill() - 1));
                    habitatPredators.Add(new Predator(habitatPredators[0].getSkill() + 1));
                    habitatPredators.RemoveAt(0);
                    habitatPrey.RemoveAt(0);
                    PredatorSort();
                    flag = true;
                }
                else
                {
                    break;
                }
            }

            if (habitatPrey.Count == 1)
            {
                habitatPrey.Add(new Prey(habitatPrey[0].getSkill() - 1));
                habitatPrey.Add(new Prey(habitatPrey[0].getSkill() + 1));
                habitatPrey.RemoveAt(0);
                PreySort();
                flag = true;
            }
        }   

    }

    private void PreySort()
    {
        for (int i = 0; i < habitatPrey.Count; i++)
        {
            int min = habitatPrey[i].getSkill();
            int minIndex = i;
            for (int j = i; j < habitatPrey.Count; j++)
            {
                if (min > habitatPrey[j].getSkill())
                {
                    min = habitatPrey[j].getSkill();
                    minIndex = j;
                }
            }
            Prey temp = habitatPrey[i];
            habitatPrey[i] = habitatPrey[minIndex];
            habitatPrey[minIndex] = temp;

        }
    }
    
    private void PredatorSort()
    {
        for (int i = 0; i < habitatPredators.Count; i++){
            int max = habitatPredators[i].getSkill();
            int maxIndex = i;
            for (int j = i; j < habitatPredators.Count; j++)
            {
                if (max < habitatPredators[j].getSkill())
                {
                    max = habitatPredators[j].getSkill();
                    maxIndex = j;
                }
            }
            Predator temp = habitatPredators[i];
            habitatPredators[i] = habitatPredators[maxIndex];
            habitatPredators[maxIndex] = temp;
            
        }
    }
}
    
    

