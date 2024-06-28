using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// 不继承MonoBehaviour的单例模式
/// </summary>
public class SingtonBase<T>
    where T:SingtonBase<T>//约束T类型是继承自SingtonBase
{
    protected SingtonBase() { }
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = Activator.CreateInstance(typeof(T), true) as T;
            };
            return instance;
        }
    }


}
