using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocisk : MonoBehaviour
{
    Vector3 pozycjaKursora;
    Vector3 kierunek;
    float szybkosc = 10f;

    void Start()
    {
        ZdefiniujKierunekStrzalu();
        Destroy(gameObject, 2f);
    }

    void ZdefiniujKierunekStrzalu()
    {
        pozycjaKursora = Input.mousePosition;
        pozycjaKursora = Camera.main.ScreenToWorldPoint(pozycjaKursora);
        pozycjaKursora.z = 0;

        kierunek = pozycjaKursora - transform.position;
    }

    void Update()
    {
        transform.position += kierunek.normalized * szybkosc * Time.deltaTime;
    }
}
