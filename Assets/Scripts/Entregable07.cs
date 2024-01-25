using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entregable07 : MonoBehaviour
{
    private int sum = 0;

    [SerializeField] private string[] letras;
    private int numletras = 0;

    private int randnum = 0;
    private int randsum = 0;
    private int fives = 0;

    private string palabra = "esternocleidomastoidal";
    private bool encontrar = false;

    void Start()
    {
        //Exercise01();
        //Exercise02();
        //Exercise03();
        //Exercise04();
        Exercise05();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Exercise01()
    {
        for(int i = 1; i <= 100; i++)
        {
            if(i%2 == 0)
            {
                sum += i;
            }
        }
        Debug.Log(sum);
    }

    private void Exercise02()
    {
        foreach(string letra in letras)
        {
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                numletras++;
            }
        }

        Debug.Log(numletras);
    }

    private void Exercise03()
    {
        for (int i = 10;  i >=1; i--)
        {
            Debug.Log(i + " green bottles\nHanging on the wall\n" + i + " green bottles\nHanging on the wall\nAnd if one green bottle\nShould accidentally fall\nThere'll be " + (i-1) + " green bottles\nHanging on the wall");
        }
    }

    private void Exercise04()
    {
        while(randnum != 5 || randsum < 100)
        {
            randnum = Random.Range(1, 11);
            randsum += randnum;
            if(randnum == 5)
            {
                fives++;
            }
        }
        Debug.Log(fives);
        Debug.Log(randsum);
    }

    private void Exercise05()
    {
        for (int i=0; i<palabra.Length && !encontrar; i++)
        {
            Debug.Log(palabra[i]);
            if (palabra[i] == 'a')
            {
                encontrar = true;
            }
        }
    }
}
