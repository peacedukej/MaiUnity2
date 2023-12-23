using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Barrier : MonoBehaviour
{
    private float _barrierSpeed;
    private void Update()
    {
        _barrierSpeed = -0.2f;
        transform.Translate(x:0, y:0, z:_barrierSpeed);
                // Проверяем, достигло ли препятствие нужной координаты
        if (transform.position.z <= -500f)
        {
            // Если достигло, уничтожаем объект
            Destroy(gameObject);
        }
    }

}
