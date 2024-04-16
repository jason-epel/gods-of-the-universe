using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour {

    private Grid grid;

    private void Start() {
        grid = new Grid(20, 20, 10f, new Vector3(0,0));
        new Grid(2, 15, 10f, new Vector3(-40, 50));
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
