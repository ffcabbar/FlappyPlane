using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform ucak;
    public float xdegeri;

    void Start()
    {

    }


    void Update()
    {
        transform.position = new Vector3(ucak.position.x + xdegeri, 0,-10);
    }
}
