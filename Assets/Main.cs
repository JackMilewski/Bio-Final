using System;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Habitat[,] board;
    public static int gen;
    void Start()
    {
        board = new Habitat[5, 5];

        for (double i = 2; i < 8; i++)
        {
            for (int j = 0; j < 4 - (5 - Math.Abs(i)); j++)
            {
                board[UnityEngine.Random.Range(0, 4), UnityEngine.Random.Range(0, 4)].habitatPrey.Add(new Prey((int)i));
                board[UnityEngine.Random.Range(0, 4), UnityEngine.Random.Range(0, 4)].habitatPredators.Insert(0, new Predator((int)i));
            }
        }
    }

    public static void Round()
    {
        gen++;
        foreach (Habitat habitat in board)
        {
            habitat.Simulate();
        }
    }
}
