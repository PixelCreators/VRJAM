using UnityEngine;
using System.Collections;

public class PointsManager : MonoBehaviour
{

    private static int Points;

    public void Start()
    {
        Points = 0;
    }

    public static void AddPoints()
    {
        Points += Random.Range(100, 300);
        PointsController.UpdateText(Points);
    }

    public static void AddBonus()
    {
        Points += 1000;
        PointsController.UpdateText(Points);
    }
}
