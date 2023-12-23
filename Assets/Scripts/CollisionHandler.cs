using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Проверяем столкновение с барьером
        if (other.gameObject.tag == "Barrier")
        {
            // Вызываем метод завершения игры
            print("Enter");
        }
    }
}
