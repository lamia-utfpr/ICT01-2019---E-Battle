﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pag_anterior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void mudarPagina(){
        if (GameObject.Find("tabela").GetComponent<tabela>().get_PaginaTabela() - 1 >= 1){
            GameObject.Find("tabela").GetComponent<tabela>().set_PaginaTabela(GameObject.Find("tabela").GetComponent<tabela>().get_PaginaTabela()-1);
            GameObject.Find("tabela").GetComponent<tabela>().preencherTemas(null);
        }
    }
}