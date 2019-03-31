using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ucak : MonoBehaviour
{
    public float hiz, yukselisHizi,mesafe,skormesafe;
    public Transform baslangicNoktasi;
    public Text mesafeYazi,mesafeoyunsonuYazi,skormesafeYazi;
    public GameObject oyunsonuPanel, oyunPanel, baslangicPanel;

    void Start()
    {
        oyunsonuPanel.SetActive(false);
        oyunPanel.SetActive(false);
        baslangicPanel.SetActive(true);

        hiz = 0;
        yukselisHizi = 0;
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

   
    void Update()
    {
        mesafe = Vector2.Distance(baslangicNoktasi.position, transform.position);

        mesafeYazi.text = (int) mesafe + "M";

        transform.Translate(hiz*Time.deltaTime,0,0);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetTouch(0).tapCount==1)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * yukselisHizi);
        }
    }

    void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.tag=="Gecis")
        {
            nesne.gameObject.transform.root.gameObject.GetComponent<Yol>().aktif = true;
        }
    }

    void OnCollisionEnter2D(Collision2D nesne)
    {
        if (nesne.gameObject.tag=="Engel")
        {
            Time.timeScale = 0;
            OyunSonu();
        }
    }

    public void Butonlar(int i)
    {
        if (i==0)
        {
            hiz = 5;
            yukselisHizi = 200;
            GetComponent<Rigidbody2D>().gravityScale = 1;
            oyunPanel.SetActive(true);
            oyunsonuPanel.SetActive(false);
            baslangicPanel.SetActive(false);

        }
    }

    void OyunSonu()
    {
        oyunPanel.SetActive(false);
        oyunsonuPanel.SetActive(true);
        mesafeoyunsonuYazi.text = "MESAFE : "+(int) mesafe + "M";

        skormesafe = PlayerPrefs.GetFloat("SkorMesafemiz");
        if (skormesafe>mesafe)
        {
            skormesafeYazi.text="SKOR MESAFE : "+(int)skormesafe + "M";
        }
        else
        {
            skormesafe = mesafe;
            PlayerPrefs.SetFloat("SkorMesafemiz",skormesafe);
            skormesafeYazi.text = "SKOR MESAFE : " + (int) skormesafe + "M";
        }
    }
}
