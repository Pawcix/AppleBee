using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Poruszanie : MonoBehaviour
{
    float moveX;
    float moveY;
    float szybkosc = 7f;

    void Update()
    {
        Vector3 pos = transform.position;
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        pos += new Vector3(moveX, moveY, 0) * szybkosc * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -8.2f, 8.2f);
        pos.y = Mathf.Clamp(pos.y, -4.3f, 4.3f);
        transform.position = pos;
    }
}
