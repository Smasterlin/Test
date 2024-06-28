using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void Awake()
    {
        EventCenterController.Instance.AddListener("renwu", Spheres);
    }
    public void Spheres()
    {
        Debug.Log("This is a Sphere");
    }
}
