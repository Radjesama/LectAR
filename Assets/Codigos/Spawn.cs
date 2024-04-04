using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Random;
using System;

public class Spawn : MonoBehaviour
{
    public Transform s1, s2, s3, s4, s5;
    public GameObject o1, o2, o3, o4, o5;
    
    public void Aparecer(){
        int[] numeros = new int[5];
        int[] objetos = new int[5];
        System.Random num = new System.Random();
        int numeroAleatorio;

        for (int i = 0; i < numeros.Length; i++)
        {
            do
            {
                numeroAleatorio = num.Next(1, 6);
            } while (Array.IndexOf(numeros, numeroAleatorio) != -1);

            numeros[i] = numeroAleatorio;
        }

        for (int i = 0; i < objetos.Length; i++)
        {
            do
            {
                numeroAleatorio = num.Next(1, 6);
            } while (Array.IndexOf(objetos, numeroAleatorio) != -1);

            objetos[i] = numeroAleatorio;
        }


        for (int i = 0; i < objetos.Length; i++){
            if(objetos[i] == 1){
                if(numeros[i] == 1){
                    o1.transform.position = s1.position;
                }
                if(numeros[i] == 2){
                    o1.transform.position = s2.position;
                }
                if(numeros[i] == 3){
                    o1.transform.position = s3.position;
                }
                if(numeros[i] == 4){
                    o1.transform.position = s4.position;
                }
                if(numeros[i] == 5){
                    o1.transform.position = s5.position;
                }
            }

            if(objetos[i] == 2){
                if(numeros[i] == 1){
                    o2.transform.position = s1.position;
                }
                if(numeros[i] == 2){
                    o2.transform.position = s2.position;
                }
                if(numeros[i] == 3){
                    o2.transform.position = s3.position;
                }
                if(numeros[i] == 4){
                    o2.transform.position = s4.position;
                }
                if(numeros[i] == 5){
                    o2.transform.position = s5.position;
                }
            }

            if(objetos[i] == 3){
                if(numeros[i] == 1){
                    o3.transform.position = s1.position;
                }
                if(numeros[i] == 2){
                    o3.transform.position = s2.position;
                }
                if(numeros[i] == 3){
                    o3.transform.position = s3.position;
                }
                if(numeros[i] == 4){
                    o3.transform.position = s4.position;
                }
                if(numeros[i] == 5){
                    o3.transform.position = s5.position;
                }
            }

            if(objetos[i] == 4){
                if(numeros[i] == 1){
                    o4.transform.position = s1.position;
                }
                if(numeros[i] == 2){
                    o4.transform.position = s2.position;
                }
                if(numeros[i] == 3){
                    o4.transform.position = s3.position;
                }
                if(numeros[i] == 4){
                    o4.transform.position = s4.position;
                }
                if(numeros[i] == 5){
                    o4.transform.position = s5.position;
                }
            }

            if(objetos[i] == 5){
                if(numeros[i] == 1){
                    o5.transform.position = s1.position;
                }
                if(numeros[i] == 2){
                    o5.transform.position = s2.position;
                }
                if(numeros[i] == 3){
                    o5.transform.position = s3.position;
                }
                if(numeros[i] == 4){
                    o5.transform.position = s4.position;
                }
                if(numeros[i] == 5){
                    o5.transform.position = s5.position;
                }
            }
        }
    }


}
