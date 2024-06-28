using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// ���̳�MonoBehaviour�ĵ���ģʽ
/// </summary>
public class SingtonBase<T>
    where T:SingtonBase<T>//Լ��T�����Ǽ̳���SingtonBase
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
