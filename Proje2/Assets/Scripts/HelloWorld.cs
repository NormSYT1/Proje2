using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    string divisions2 = " ", divisions3 = " ", divisions4 = " ", divisions5 = " ";
    void Start()
    {
        FindDivisions(15, 60);//Fonksiyonu çaðýr
        print("Ýkiye bölünenler: " + divisions2);
        print("Üçe bölünenler: " + divisions3);
        print("Dörde bölünenler " + divisions4);
        print("Beþe bölünenler: " + divisions5);
    }
    void Update()
    {

    }
    public void FindDivisions(int number1, int number2)
    {
        if (number1 <= number2)//1.sayý daha büyükse
        {
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 == 0)//Sayý 2 ye tam bölünüyorsa
                {
                    divisions2 += " " + i.ToString();//Sayýyý ikiye bölünenler kýsmýna ekle
                }
                if (i % 3 == 0)//Sayý 3 e tam bölünüyorsa
                {
                    divisions3 += " " + i.ToString();//Sayýyý üçe bölünenler kýsmýna ekle
                }
                if (i % 4 == 0)//Sayý 4 e tam bölünüyorsa
                {
                    divisions4 += " " + i.ToString();//Sayýyý dörde bölünenler kýsmýna ekle
                }
                if (i % 5 == 0)//Sayý 5 e tam bölünüyorsa
                {
                    divisions5 += " " + i.ToString();//Sayýyý beþe bölünenler kýsmýna ekle
                }
            }
        }
        else//2.sayý daha büyükse
        {
            for (int i = number2; i <= number1; i++)
            {
                if (i % 2 == 0)//Sayý 2 ye tam bölünüyorsa
                {
                    divisions2 += " " + i.ToString();//Sayýyý ikiye bölünenler kýsmýna ekle
                }
                if (i % 3 == 0)//Sayý 3 e tam bölünüyorsa
                {
                    divisions3 += " " + i.ToString();//Sayýyý üçe bölünenler kýsmýna ekle
                }
                if (i % 4 == 0)//Sayý 4 e tam bölünüyorsa
                {
                    divisions4 += " " + i.ToString();//Sayýyý dörde bölünenler kýsmýna ekle
                }
                if (i % 5 == 0)//Sayý 5 e tam bölünüyorsa
                {
                    divisions5 += " " + i.ToString();//Sayýyý beþe bölünenler kýsmýna ekle
                }
            }
        }
    }
}
