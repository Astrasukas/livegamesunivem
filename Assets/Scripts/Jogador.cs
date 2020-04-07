﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(velocidade, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-velocidade, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, velocidade, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -velocidade, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //programe aqui oque fazer quando apertar espaço

        }

        if (Input.GetMouseButtonDown(0))
        {
            //programe aqui oque fazer quando apertar botao esquerdo

        }


    }
}
