using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Barrier;
    private void Start()
    {
        InvokeRepeating("SpawnItem", 0, 4f);
        if (Barrier.transform.position.z == -5f)
        {
            // Уничтожаем объект
            Destroy(Barrier);
        }
    }

    private void SpawnItem()
    {
        Instantiate(Barrier);
        Barrier.transform.position = new Vector3(Random.Range(-10, 10), 4, 50);
    }

}


