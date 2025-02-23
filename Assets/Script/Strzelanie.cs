using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzelanie : MonoBehaviour
{
    [SerializeField] GameObject pociskPrefab;
    AudioSource audios;

    void Start()
    {
        audios = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            UtworzPociskNaScenie();
        }
    }

    void UtworzPociskNaScenie()
    {
        GameObject pocisk = Instantiate(pociskPrefab);
        pocisk.transform.position = gameObject.transform.position;
        audios.Play();
    }
}
