﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarSpawnPowerUps : MonoBehaviour
{
    // Start is called before the first frame update

    private static int intervalo_entre_casas;
    private static int casa_atual = 0;
    private int quantia_casas = 20;
    private int quantia_powerups = 3;
    private string[] nome_powerups;

    void Start()
    {
        //power ups disponíveis durante a partida

        nome_powerups = new string[quantia_powerups];
        nome_powerups[0] = "Aumentar tempo";
        nome_powerups[1] = "Eliminar alternativas";
        nome_powerups[2] = "Dado maior";
        /*nome_powerups[3] = "Dado maior 3";
        nome_powerups[4] = "Dado maior 4";
        */
        //a distancia entre cada power up, no caso, quantas casas o player tem que percorrer pra pegar o próximo power up

        intervalo_entre_casas = Random.Range(3, 5);
        //intervalo_entre_casas = 1;
        preencherCasas();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string[] powerUpsPossiveis(){
        return nome_powerups;
    } 

    //função que preenche as casas do tabuleiro de acordo com a quantia existente, exclui a casa inicial e a casa final na hora de preencher.

    private void preencherCasas(){
        int[] aux = new int[Tabuleiro.get_quantiaCasas()];

        
        
        for (int i = 0; i < aux.Length; i++){
            
            //esse if verifica se a casa atual deve ter um power up de acordo com o intervalo definido na função Start(), e caso deva ter, então é procurado o objeto com o nome da casa
            //e suas variáveis são alteradas, as variáveis são "temPowerUp" e "nomePowerUp". Após definir os valores para as casas, as variáveis responsáveis por verificar se a casa deve
            //ou não ter um power up são resetadas

        //Debug.Log("Casa atual do vetor: " + i);
            

            if (casa_atual == intervalo_entre_casas){
                Debug.Log("Entrou");
                /*
                GameObject.Find("casa " + i).GetComponent<GerenciarCasas>().setTemPowerUp(true);
                GameObject.Find("casa " + i).GetComponent<GerenciarCasas>().set_nomePowerUp(nome_powerups[Random.Range(0, quantia_powerups)]);
                

                Debug.Log(GameObject.Find("casa " + i).name + GameObject.Find("casa " + i).GetComponent<GerenciarCasas>().get_nomePowerUp());
                */

                aux[i] = 1;
                Debug.Log("A casa " + i + " tem um power up!");

                casa_atual = 0;
                intervalo_entre_casas = 1;//Random.Range(3, 5);
                
            }else{
                aux[i] = 0;
                casa_atual++;    
            }
        }

        Tabuleiro.setPowerUpsTabuleiro(aux);

    }

   

}