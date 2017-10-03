//Skript für den Mittelpunkt. Der ist quasi das zentrale Organ, was die "richtige" Farbe bestimmt.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Mittelpunkt : MonoBehaviour
{

    public static bool red1 = false;
    public static bool red2 = false;
    public static bool red3 = false;
    public static bool red4 = false;
    public static bool blue1 = false;
    public static bool blue2 = false;
    public static bool blue3 = false;
    public static bool blue4 = false;
    public static bool yellow1 = false;
    public static bool yellow2 = false;
    public static bool yellow3 = false;
    public static bool yellow4 = false;
    public static bool green1 = false;
    public static bool green2 = false;
    public static bool green3 = false;
    public static bool green4 = false;
    public static bool orange1 = false;
    public static bool orange2 = false;
    public static bool orange3 = false;
    public static bool orange4 = false;
    public static bool brown1 = false;
    public static bool brown2 = false;
    public static bool brown3 = false;
    public static bool brown4 = false;
    public static bool gray1 = false;
    public static bool gray2 = false;
    public static bool gray3 = false;
    public static bool gray4 = false;




    void Retry()
    {
        if (RETRYauswirkung.retry == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.white);
        }
    }

    //Randomrythmus;
    void Rnd()
    {
        System.Random Rnd = new System.Random();
        int a = Rnd.Next(0, 28);

        if (a == 0)
        {
            red1 = true;
        }
        else if (a == 1)
        {
            red2 = true;
        }
        else if (a == 2)
        {
            red3 = true;
        }
        else if (a == 3)
        {
            red4 = true;
        }
        else if (a == 4)
        {
            blue1 = true;
        }
        else if (a == 5)
        {
            blue2 = true;
        }
        else if (a == 6)
        {
            blue3 = true;
        }
        else if (a == 7)
        {
            blue4 = true;
        }
        else if (a == 8)
        {
            yellow1 = true;
        }
        else if (a == 9)
        {
            yellow2 = true;
        }
        else if (a == 10)
        {
            yellow3 = true;
        }
        else if (a == 11)
        {
            yellow4 = true;
        }
        else if (a == 12)
        {
            green1 = true;
        }
        else if (a == 13)
        {
            green2 = true;
        }
        else if (a == 14)
        {
            green3 = true;
        }
        else if (a == 15)
        {
            green4 = true;
        }
        else if (a == 16)
        {
            orange1 = true;
        }
        else if (a == 17)
        {
            orange2 = true;
        }
        else if (a == 18)
        {
            orange3 = true;
        }
        else if (a == 19)
        {
            orange4 = true;
        }
        else if (a == 20)
        {
            brown1 = true;
        }
        else if (a == 21)
        {
            brown2 = true;
        }
        else if (a == 22)
        {
            brown3 = true;
        }
        else if (a == 23)
        {
            brown4 = true;
        }
        else if (a == 24)
        {
            gray1 = true;
        }
        else if (a == 25)
        {
            gray2 = true;
        }
        else if (a == 26)
        {
            gray3 = true;
        }
        else if (a == 27)
        {
            gray4 = true;
        }
    }


    void again()
    {
        if (CircleA.clicked == true)
        {
            Rnd();
            Red();
            Green();
            Yellow();
            Orange();
            Gray();
            Brown();
            Blue();
            CircleA.clicked = false;
        }
    }


    void Start()
    {
        Rnd();
        Red();
        Green();
        Yellow();
        Orange();
        Gray();
        Brown();
        Blue();
    }

    private void Update()
    {
        Retry();
        again();
    }

    void Red()
    {

        if (red1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.red);
        }
        else if (red2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.red);
        }
        else if (red3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.red);
        }
        else if (red4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.red);
        }

    }

    void Blue()
    {
        if (blue1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.blue);
        }
        else if (blue2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.blue);
        }
        else if (blue3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.blue);
        }
        else if (blue4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.blue);
        }
    }

    void Green()
    {
        if (green1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.green);
        }
        else if (green2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.green);
        }
        else if (green3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.green);
        }
        else if (green4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.green);
        }
    }

    void Yellow()
    {
        if (yellow1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
        }
        else if (yellow2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
        }
        else if (yellow3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
        }
        else if (yellow4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
        }
    }

    void Orange()
    {
        if (orange1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
        }
        else if (orange2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
        }
        else if (orange3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
        }
        else if (orange4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
        }
    }

    void Brown()
    {
        if (brown1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.gray);
        }
        else if (brown2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.gray);
        }
        else if (brown3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.gray);
        }
        else if (brown4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.gray);
        }
    }

    void Gray()
    {
        if (gray1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.gray);
        }
        else if (gray2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.gray);
        }
        else if (gray3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.gray);
        }
        else if (gray4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.gray);
        }
    }

}
