using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="BallConfig")]
public class BallConfig : ScriptableObject
{ 
    public float force = 25000; 
    public Vector3 initialPosition = new Vector3(0,-2,-120);
    public GameObject ballPrefab;

}
