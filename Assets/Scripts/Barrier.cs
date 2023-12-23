using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Barrier : MonoBehaviour
{
    private float _barrierSpeed;
    private void Update()
    {
        _barrierSpeed -= 0.0001f;
        transform.Translate(x:0, y:0, z:_barrierSpeed);

    }

}
