using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SpawnObject()
    {
        return Instantiate(Resources.Load("CubePrefab", typeof(GameObject))) as GameObject;
    }
}
