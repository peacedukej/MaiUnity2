using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    public float moveSpeed = 5f;   // Скорость движения полос дороги
    public float roadLength = 1f; // Длина полосы дороги

    void Start()
    {
        // Начальное смещение полос дороги для корректного старта
        transform.Translate(Vector3.forward * roadLength);
    }

    void Update()
    {
        MoveRoad();  // Вызываем функцию движения дороги
    }

    void MoveRoad()
    {
        // Двигаем полосы дороги вперёд
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        // Если полосы дороги выходят за пределы камеры, перемещаем их вперёд
        if (transform.position.z < -roadLength)
        {
            // Определяем смещение, чтобы перенести полосу в конец
            float offset = Mathf.Repeat(transform.position.z + roadLength, roadLength * 2f) - roadLength;

            // Перемещаем полосу в конец
            transform.Translate(Vector3.forward * (-offset + roadLength));
        }
    }
}
