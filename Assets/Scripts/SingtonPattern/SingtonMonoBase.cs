using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 继承子MonoBehaviour的单例模式
/// </summary>
public class SingtonMonoBase<T> : MonoBehaviour
    where T:MonoBehaviour
{
    protected SingtonMonoBase() { }
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance==null)
            {
                instance =FindObjectOfType<T>();
            }
            return instance;
        }
    }
}
