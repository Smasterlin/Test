using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class EventCenterController : SingtonBase<EventCenterController>
{
    Dictionary<string, UnityAction> EventCenter = new();


    public void AddListener(string key,UnityAction call)
    {
        if (EventCenter.ContainsKey(key))
        {
            EventCenter[key] += call;
        }
        else
        {
            EventCenter.Add(key,call);
        }
    }

    public void Patch(string key)
    {
        EventCenter[key]?.Invoke();
    }
    private void RemoveListener()
    {

    }
}
