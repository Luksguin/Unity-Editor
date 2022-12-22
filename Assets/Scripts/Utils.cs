using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static T RandomList<T>(this List<T> list)
    {
        if(list == null || list.Count == 0)
        {
            return default(T);
        }

        return list[Random.Range(0, list.Count)];
    }
}
