using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �̳���MonoBehaviour�ĵ���ģʽ
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
