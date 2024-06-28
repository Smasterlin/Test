using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 不继承Monobehaviour的单例模式
/// </summary>
public class PlayerModel:SingtonBase<PlayerModel>
{
    //private PlayerModel() { }
    //private static PlayerModel instance;
    //public static PlayerModel Instance { 
    //    get
    //    {
    //        if (instance==null)
    //        {
    //            instance = new PlayerModel();
    //        }
    //        return instance;
    //    } }
    int money = 999;
    int diamond = 6666;
    public void ShowData()
    {
        Debug.Log(money);
        Debug.Log(diamond);
    }
}
