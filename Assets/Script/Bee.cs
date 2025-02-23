using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Bee : MonoBehaviour
{
    [SerializeField] AudioSource audios;
    GameObject gracz;
    GameObject gmanager;

    Vector3 pozycjaGracza;
    Vector3 kierunek;

    float szybkosc = 3f;

    void Start()
    {
        gracz = GameObject.FindWithTag("Player");
        gmanager = GameObject.FindWithTag("GameManager");
    }
    void Update()
    {
        ZnajdujGracza();
        PoruszajSieWKierunkiGracza();
    }

    void ZnajdujGracza()
    {
        if(gracz != null)
        {
            pozycjaGracza = gracz.transform.position;
        }
    }

    void PoruszajSieWKierunkiGracza()
    {
        kierunek = pozycjaGracza - transform.position;
        transform.position += kierunek.normalized * szybkosc * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pocisk")
        {
            gmanager.GetComponent<GameManager>().DodajPunkt();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            audios.Play();
            gmanager.GetComponent<GameManager>().GameOver();
        }
    }
}
