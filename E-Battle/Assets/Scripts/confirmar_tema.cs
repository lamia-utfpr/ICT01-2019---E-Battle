﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmar_tema : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void confirmarTema(){
        GameObject.Find("tabela").GetComponent<tabela>().confirmar_tema();
    }
}
