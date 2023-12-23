using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Barrier1;
    private void Start()
    {
        InvokeRepeating("SpawnItem", 0, 4f);
        // if (Barrier.transform.position.z == -5f)
        // {
        //     // Уничтожаем объект
        //     Destroy(Barrier);
        // }
    }

    private void SpawnItem()
    {
        Instantiate(Barrier1);
        Barrier1.transform.position = new Vector3(Random.Range(-4, 4), 0, 50);
    }

}


