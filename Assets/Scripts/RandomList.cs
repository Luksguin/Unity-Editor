using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomList : MonoBehaviour
{
    public List<GameObject> gameObjects;
    GameObject randomObject;

    [UnityEditor.MenuItem("Itens/Create")]
    public static void Create()
    {
        Debug.Log("Teste");
    }

    private void Update()
    {
        if(randomObject != null)
        {
            randomObject.transform.position = transform.position;
        }
    }

    public void Random()
    {
        if(randomObject != null)
        {
            randomObject.SetActive(false);
        }

        randomObject = gameObjects.RandomList();

        randomObject.SetActive(true);
        Debug.Log(randomObject.name);
    }
}
