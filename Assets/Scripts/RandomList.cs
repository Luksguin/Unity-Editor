using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomList : MonoBehaviour
{
    public List<GameObject> gameObjects;
    private List<GameObject> olderGameObjects;

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
        GameObject randomObject = gameObjects.RandomList();

        /*if(randomObject != null)
        {
            randomObject.SetActive(false);
        }*/

        if(olderGameObjects.Count > 0)
        {
            olderGameObjects[0].gameObject.SetActive(false);
            olderGameObjects.Clear();
        }

        randomObject.transform.position = transform.position;
        randomObject.SetActive(true);

        olderGameObjects.Add(randomObject);

        //Debug.Log(olderGameObjects.Count);
    }
}
