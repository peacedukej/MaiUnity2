using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TreesGeneration : MonoBehaviour
{
    [SerializeField] private GameObject treesLeft;
    [SerializeField] private GameObject treesRight;
    private void Start()
    {
        InvokeRepeating("SpawnItem", 0, 0.2f);
    }

    private void SpawnItem()
    {
        Instantiate(treesLeft);
        treesLeft.transform.position = new Vector3(Random.Range(-10, -5), 0, 50);
        Instantiate(treesRight);
        treesRight.transform.position = new Vector3(Random.Range(5, 10), 0, 50);
    }

}


