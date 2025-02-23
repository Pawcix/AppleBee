using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text txtPunkty;
    [SerializeField] Text txtLicznik;
    [SerializeField] GameObject beePrefab;
    [SerializeField] Transform[] pozycjeDoSpawnowania;

    public AudioSource myAudio;

    int punkty = 0;
    float counter;

    bool czyGraJestAktywna;

    void Start()
    {
        czyGraJestAktywna = true;
        GenerowanieOdIlosci();
    }

    void Update()
    {
        Invoke("StworzenieTimeraWGrze", 5f);
    }

    public void StworzenieTimeraWGrze()
    {
        if(czyGraJestAktywna == true) 
        {
            counter += Time.deltaTime;
            txtLicznik.text = counter.ToString();
        }
    }

    void GenerowanieOdIlosci()
    {
        InvokeRepeating("TworzBee", 5f, 0.5f);
    }

    void TworzBee()
    {
        GameObject pszczolka = Instantiate(beePrefab);

        int losowaLiczba = Random.Range(0, pozycjeDoSpawnowania.Length);
        pszczolka.transform.position = pozycjeDoSpawnowania[losowaLiczba].transform.position;    
    }

    public void GameOver()
    {
        czyGraJestAktywna = false;
        Invoke("ZakonczenieGry", 5);
    }

    void ZakonczenieGry()
    {
        SceneManager.LoadScene(0);
    }

    public void DodajPunkt()
    {
        punkty++;
        txtPunkty.text = punkty.ToString();
    }
}
