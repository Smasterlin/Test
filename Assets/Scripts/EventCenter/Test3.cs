using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 120, 150), "∑¢ÀÕ√¸¡Ó"))
        {
            EventCenterController.Instance.Patch("renwu");
        };
    }
}
