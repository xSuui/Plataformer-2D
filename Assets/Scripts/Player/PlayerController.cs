using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
        private AudioSource audioSource;

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Toca o som de pulo
                audioSource.Play();

                // Adicione aqui o c�digo para o pulo
            }
        }
 }

