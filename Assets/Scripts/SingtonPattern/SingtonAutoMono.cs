using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �̳���MonoBehaviour���Զ�����ģʽ
/// </summary>
public class SingtonAutoMono<T> : MonoBehaviour
    where T:MonoBehaviour
{
    protected SingtonAutoMono() { }
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance==null)
            {
                GameObject go = new(typeof(T).Name);
                instance= go.AddComponent<T>();
            }
            return instance;
        }
    }
}
