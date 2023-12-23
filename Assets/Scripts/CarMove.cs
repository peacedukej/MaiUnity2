// using UnityEngine;

// public class Player : MonoBehaviour
// {
//     private bool _moveRight, _moveLeft;

//     private void Update()
//     {
//         // Обработка движения вправо при нажатии кнопки D
//         if (Input.GetKey("d") || _moveRight)
//         {
//             transform.Translate(new Vector3(0.03f, 0, 0));
//         }

//         // Обработка движения влево при нажатии кнопки A
//         if (Input.GetKey("a") || _moveLeft)
//         {
//             transform.Translate(new Vector3(-0.03f, 0, 0));
//         }
//     }

//     // Вызывается из внешних источников (например, кнопок управления)
//     public void MoveR(bool moveRight)
//     {
//         _moveRight = moveRight;
//     }

//     public void MoveL(bool moveLeft)
//     {
//         _moveLeft = moveLeft;
//     }
// }

using UnityEngine;

public class Player : MonoBehaviour
{
    private bool _moveRight, _moveLeft;
    public float moveSpeed = 0.03f;
    public float minX = -4f;
    public float maxX = 4f;

    private void Update()
    {
        // Обработка движения вправо при нажатии кнопки D
        if ((Input.GetKey("d") || _moveRight) && transform.position.x < maxX)
        {
            MoveRight();
        }

        // Обработка движения влево при нажатии кнопки A
        if ((Input.GetKey("a") || _moveLeft) && transform.position.x > minX)
        {
            MoveLeft();
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

    private void MoveRight()
    {
        transform.Translate(new Vector3(moveSpeed, 0, 0));
        ClampPosition();
    }

    private void MoveLeft()
    {
        transform.Translate(new Vector3(-moveSpeed, 0, 0));
        ClampPosition();
    }

    private void ClampPosition()
    {
        // Ограничение позиции машинки в пределах от minX до maxX
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        transform.position = clampedPosition;
    }
}
