using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Trees : MonoBehaviour
{
    private float _treesSpeed;
    private void Update()
    {
        _treesSpeed = -0.2f;
        transform.Translate(x:0, y:0, z:_treesSpeed);
                // Проверяем, достигло ли препятствие нужной координаты
        if (transform.position.z <= -125f)
        {
            // Если достигло, уничтожаем объект
            Destroy(gameObject);
        }
    }

}
