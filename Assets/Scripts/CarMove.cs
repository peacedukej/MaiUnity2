using UnityEngine;

public class Player : MonoBehaviour
{
    private bool _moveRight, _moveLeft;

    private void Update()
    {
        // Обработка движения вправо при нажатии кнопки D
        if (Input.GetKey("d") || _moveRight)
        {
            transform.Translate(new Vector3(0.03f, 0, 0));
        }

        // Обработка движения влево при нажатии кнопки A
        if (Input.GetKey("a") || _moveLeft)
        {
            transform.Translate(new Vector3(-0.03f, 0, 0));
        }
    }

    // Вызывается из внешних источников (например, кнопок управления)
    public void MoveR(bool moveRight)
    {
        _moveRight = moveRight;
    }

    public void MoveL(bool moveLeft)
    {
        _moveLeft = moveLeft;
    }
}
