using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    private void Awake()
    {
        EventCenterController.Instance.AddListener("renwu",Cubes);
    }

    public void Cubes()
    {
        Debug.Log("This is a cube");
    }
}
