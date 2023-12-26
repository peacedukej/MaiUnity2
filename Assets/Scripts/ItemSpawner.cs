using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Barrier1;
    [SerializeField] private GameObject Barrier2;
    private void Start()
    {
        InvokeRepeating("SpawnItem1", 0, 2f);
        InvokeRepeating("SpawnItem2", 0, 3f);
    }

    private void SpawnItem1()
    {
        Instantiate(Barrier1);
        Barrier1.transform.position = new Vector3(Random.Range(-4, 4), 0, 50);
    }

    private void SpawnItem2()
    {
        Instantiate(Barrier2);
        Barrier2.transform.position = new Vector3(Random.Range(-4, 4), 0, 50);
    }

}


