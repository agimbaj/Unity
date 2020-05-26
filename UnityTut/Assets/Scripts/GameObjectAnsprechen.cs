﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectAnsprechen : MonoBehaviour
{
    public GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        cubes = GameObject.FindGameObjectsWithTag("Cube");

    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject cube in cubes)
        {
            cube.transform.Rotate(0, 3, 0);
        }
    }
}
