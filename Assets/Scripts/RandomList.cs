using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomList : MonoBehaviour
{
    public List<GameObject> gameObjects;

    private void Start()
    {
        Random();
    }

    public void Random()
    {
        gameObjects.RandomList();
    }
}
