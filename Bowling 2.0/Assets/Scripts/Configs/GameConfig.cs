using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "GameConfig")]
public class GameConfig : ScriptableObject
{
    public float waitngTime;
    public GameObject cylinderPrefab;
    public int sprayPoint = 20;
    public int perPinPoint = 1;
    public int AdPoint = 30;
    public int ballMoveDuration = 2;
    public int planedLine_Z = -60;
}
