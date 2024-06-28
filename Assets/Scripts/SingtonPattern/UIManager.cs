using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager:SingtonAutoMono<UIManager>
{
    private UIManager() { }
    //private static UIManager instance;
    //public static UIManager Instance;
    //{
    //    get 
    //    {
    //        if (instance==null)
    //        {
    //            GameObject go = new("UIManager");

    //            instance = go.AddComponent<UIManager>();
    //            DontDestroyOnLoad(go);
    //        }
    //        return instance;
    //    }
    //}
    public void Show()
    {
        Debug.Log("´ò¿ªÃæ°å");
    }
}
