using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomList : MonoBehaviour
{
    public List<GameObject> gameObjects;
    GameObject randomObject;

    private void Start()
    {
        Random();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Random();
        }
    }

    public void Random()
    {
        if(randomObject != null)
        {
            randomObject.SetActive(false);
        }

        randomObject = gameObjects.RandomList();

        randomObject.transform.position = transform.position;
        randomObject.SetActive(true);
    }
}
