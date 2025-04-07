
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SE/Player Data", fileName = "Player Progress Data")]
public class PlayerDataSO : ScriptableObject
{
    public static float Oxygen = 120f;
    public static float Fuel = 12f;

    public Vector3 PlayerPosition;
    public Vector3 PlayerRotation;

    public List<Vector3> OxygensPositions;
    public List<Vector3> FuelPositions;
   
}
