using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    string divisions2 = " ", divisions3 = " ", divisions4 = " ", divisions5 = " ";
    void Start()
    {
        FindDivisions(15, 60);//Fonksiyonu �a��r
        print("�kiye b�l�nenler: " + divisions2);
        print("��e b�l�nenler: " + divisions3);
        print("D�rde b�l�nenler " + divisions4);
        print("Be�e b�l�nenler: " + divisions5);
    }
    void Update()
    {

    }
    public void FindDivisions(int number1, int number2)
    {
        if (number1 <= number2)//1.say� daha b�y�kse
        {
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 == 0)//Say� 2 ye tam b�l�n�yorsa
                {
                    divisions2 += " " + i.ToString();//Say�y� ikiye b�l�nenler k�sm�na ekle
                }
                if (i % 3 == 0)//Say� 3 e tam b�l�n�yorsa
                {
                    divisions3 += " " + i.ToString();//Say�y� ��e b�l�nenler k�sm�na ekle
                }
                if (i % 4 == 0)//Say� 4 e tam b�l�n�yorsa
                {
                    divisions4 += " " + i.ToString();//Say�y� d�rde b�l�nenler k�sm�na ekle
                }
                if (i % 5 == 0)//Say� 5 e tam b�l�n�yorsa
                {
                    divisions5 += " " + i.ToString();//Say�y� be�e b�l�nenler k�sm�na ekle
                }
            }
        }
        else//2.say� daha b�y�kse
        {
            for (int i = number2; i <= number1; i++)
            {
                if (i % 2 == 0)//Say� 2 ye tam b�l�n�yorsa
                {
                    divisions2 += " " + i.ToString();//Say�y� ikiye b�l�nenler k�sm�na ekle
                }
                if (i % 3 == 0)//Say� 3 e tam b�l�n�yorsa
                {
                    divisions3 += " " + i.ToString();//Say�y� ��e b�l�nenler k�sm�na ekle
                }
                if (i % 4 == 0)//Say� 4 e tam b�l�n�yorsa
                {
                    divisions4 += " " + i.ToString();//Say�y� d�rde b�l�nenler k�sm�na ekle
                }
                if (i % 5 == 0)//Say� 5 e tam b�l�n�yorsa
                {
                    divisions5 += " " + i.ToString();//Say�y� be�e b�l�nenler k�sm�na ekle
                }
            }
        }
    }
}
