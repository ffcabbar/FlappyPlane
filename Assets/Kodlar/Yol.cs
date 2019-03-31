using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yol : MonoBehaviour
{
    public bool aktif;
    public GameObject[] objeler;

    void Start()
    {
        float altsayi = Random.Range(0, 2);
        float ustsayi = Random.Range(0, 2);

        if (altsayi == 1)
        {
            objeler[1].SetActive(false);
        }
        else
        {
            objeler[1].SetActive(true);
        }

        if (ustsayi == 1)
        {
            objeler[2].SetActive(false);
        }
        else
        {
            objeler[2].SetActive(true);
        }

        if (altsayi == 1 && ustsayi == 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(-2.5f, 2.5f));
           
        }
        else if (altsayi == 1 && ustsayi != 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(-2.5f, 0));
        }
        else if (altsayi != 1 && ustsayi == 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(0, 2.5f));
        }
        else if (altsayi != 1 && ustsayi != 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(0, 0));
        }

        objeler[3].SetActive(true);
        objeler[0].transform.localPosition = new Vector2(Random.Range(-3.5f, 3.5f), 0);

    }

    
    void Update()
    {
        if (aktif)
        {   
            objeler[3].SetActive(false);
            Invoke("YoluTasi",4);
            aktif = false;
        }
    }

    void YoluTasi()
    {
        float altsayi = Random.Range(0, 3);
        float ustsayi = Random.Range(0, 3);

        if (altsayi==1)
        {
            objeler[1].SetActive(false);
        }
        else
        {
            objeler[1].SetActive(true);
        }

        if (ustsayi == 1)
        {
            objeler[2].SetActive(false);
        }
        else
        {
            objeler[2].SetActive(true);
        }

        if (altsayi==1 && ustsayi==1)
        {   
            objeler[3].transform.localPosition=new Vector2(0,Random.Range(-2.5f,2.5f));
            
        }
        else if(altsayi==1 && ustsayi != 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(-2.5f, 0));
        }
        else if (altsayi != 1 && ustsayi == 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(0, 2.5f));
        }
        else if (altsayi != 1 && ustsayi != 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(0, 0));
        }

        objeler[0].transform.localPosition=new Vector2(Random.Range(-3.5f,3.5f),0);

        transform.position = transform.position + new Vector3(40.41f, 0, 0);

        objeler[3].SetActive(true);
    }
}
