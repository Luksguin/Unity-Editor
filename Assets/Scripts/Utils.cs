using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static T RandomList<T>(this List<T> list)
    {
        Debug.Log("Teste");
        return list[Random.Range(0, list.Count)];
    }
}
