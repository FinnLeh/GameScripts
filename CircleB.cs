//Skript für den zweiten Kreis.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleB : MonoBehaviour
{

    public bool fault = false;
    public static bool scoreB = false;
    public static bool rot2 = false;
    public static bool blau2 = false;
    public static bool grün2 = false;
    public static bool gelb2 = false;
    public static bool oranje2 = false;
    public static bool braun2 = false;
    public static bool grau2 = false;


    //selbes für die anderen "Other"s
    void NumberOtherA()
    {
        if (Mittelpunkt.red2 == true || Mittelpunkt.blue2 == true || Mittelpunkt.yellow2 == true || Mittelpunkt.green2 == true || Mittelpunkt.gray2 == true || Mittelpunkt.orange2 == true || Mittelpunkt.brown2 == true)
        {
            System.Random Num = new System.Random();
            int a = Num.Next(0, 7);

            if (a == 0)
            {
                CircleA.rot1 = true;
            }
            else if (a == 1)
            {
                CircleA.blau1 = true;
            }
            else if (a == 2)
            {
                CircleA.grün1 = true;
            }
            else if (a == 3)
            {
                CircleA.gelb1 = true;
            }
            else if (a == 4)
            {
                CircleA.oranje1 = true;
            }
            else if (a == 5)
            {
                CircleA.braun1 = true;
            }
            else if (a == 6)
            {
                CircleA.grau1 = true;
            }
        }
    }

    void NumberOtherC()
    {
        if (Mittelpunkt.red2 == true || Mittelpunkt.blue2 == true || Mittelpunkt.yellow2 == true || Mittelpunkt.green2 == true || Mittelpunkt.gray2 == true || Mittelpunkt.orange2 == true || Mittelpunkt.brown2 == true)
        {
            System.Random Num = new System.Random();
            int a = Num.Next(0, 7);

            if (a == 0)
            {
                CircleC.rot3 = true;
            }
            else if (a == 1)
            {
                CircleC.blau3 = true;
            }
            else if (a == 2)
            {
                CircleC.grün3 = true;
            }
            else if (a == 3)
            {
                CircleC.gelb3 = true;
            }
            else if (a == 4)
            {
                CircleC.oranje3 = true;
            }
            else if (a == 5)
            {
                CircleC.braun3 = true;
            }
            else if (a == 6)
            {
                CircleC.grau3 = true;
            }
        }
    }

    void NumberOtherD()
    {
        if (Mittelpunkt.red2 == true || Mittelpunkt.blue2 == true || Mittelpunkt.yellow2 == true || Mittelpunkt.green2 == true || Mittelpunkt.gray2 == true || Mittelpunkt.orange2 == true || Mittelpunkt.brown2 == true)
        {
            System.Random Num = new System.Random();
            int a = Num.Next(0, 7);

            if (a == 0)
            {
                CircleD.rot4 = true;
            }
            else if (a == 1)
            {
                CircleD.blau4 = true;
            }
            else if (a == 2)
            {
                CircleD.grün4 = true;
            }
            else if (a == 3)
            {
                CircleD.gelb4 = true;
            }
            else if (a == 4)
            {
                CircleD.oranje4 = true;
            }
            else if (a == 5)
            {
                CircleD.braun4 = true;
            }
            else if (a == 6)
            {
                CircleD.grau4 = true;
            }
        }
    }

    private void OnMouseDown()
    {
        if (Mittelpunkt.red2 == true || Mittelpunkt.blue2 == true || Mittelpunkt.yellow2 == true || Mittelpunkt.green2 == true || Mittelpunkt.orange2 == true || Mittelpunkt.brown2 == true || Mittelpunkt.gray2 == true)
        {
            scoreB = true;
            CircleA.clicked = true;
            Mittelpunkt.red2 = false;
            Mittelpunkt.blue2 = false;
            Mittelpunkt.yellow2 = false;
            Mittelpunkt.green2 = false;
            Mittelpunkt.orange2 = false;
            Mittelpunkt.brown2 = false;
            Mittelpunkt.gray2 = false;
        }
        else if (Mittelpunkt.red2 != true && Mittelpunkt.blue2 != true && Mittelpunkt.yellow2 != true && Mittelpunkt.green2 != true && Mittelpunkt.orange2 != true && Mittelpunkt.brown2 != true && Mittelpunkt.gray2 != true)
        {
            Application.LoadLevel(2);
        }
    }

    //Test! noch nicht final!
    public void changeRed()
    {
        if (Mittelpunkt.red2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.red);
            NumberOtherA();
        }
    }

    public void changeBlue()
    {
        if (Mittelpunkt.blue2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.blue);
            NumberOtherA();
        }
    }

    public void changeGreen()
    {
        if (Mittelpunkt.green2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.green);
            NumberOtherA();
        }
    }

    public void changeYellow()
    {
        if (Mittelpunkt.yellow2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
            NumberOtherA();
        }
    }

    public void changeOrange()
    {
        if (Mittelpunkt.orange2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.black);
            NumberOtherA();
        }
    }

    public void changeBrown()
    {
        if (Mittelpunkt.brown2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.black);
            NumberOtherA();
        }
    }

    public void changeGray()
    {
        if (Mittelpunkt.gray2 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.gray);
            NumberOtherA();
        }
    }

    void Retry()
    {
        if (RETRYauswirkung.retry == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.white);
            RETRYauswirkung.retry = false;
        }
    }


    //die, wenn es nicht die richtige Farbe ist.
    void otherB()
    {
        if (Mittelpunkt.red2 != true && Mittelpunkt.blue2 != true && Mittelpunkt.yellow2 != true && Mittelpunkt.gray2 != true && Mittelpunkt.green2 != true && Mittelpunkt.orange2 != true && Mittelpunkt.brown2 != true)
        {
            Renderer REND = GetComponent<Renderer>();
            REND.material.shader = Shader.Find("GUI/Text Shader");
            REND.material.SetColor("_Color", Color.white);
            if (Mittelpunkt.red1 == true || Mittelpunkt.red3 == true || Mittelpunkt.red4 == true)
            {
                if (rot2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
                else if (blau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.blue1 == true || Mittelpunkt.blue3 == true || Mittelpunkt.blue4 == true)
            {
                if (rot2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (grün2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.green1 == true || Mittelpunkt.green3 == true || Mittelpunkt.green4 == true)
            {
                if (rot2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (gelb2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.yellow1 == true || Mittelpunkt.yellow3 == true || Mittelpunkt.yellow4 == true)
            {
                if (rot2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (oranje2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.orange1 == true || Mittelpunkt.orange3 == true || Mittelpunkt.orange4 == true)
            {
                if (rot2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (braun2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.brown1 == true || Mittelpunkt.brown3 == true || Mittelpunkt.brown4 == true)
            {
                if (rot2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.gray1 == true || Mittelpunkt.gray3 == true || Mittelpunkt.gray4 == true)
            {
                if (rot2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau2 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
            }
           /* rot2 = false;
            blau2 = false;
            grün2 = false;
            gelb2 = false;
            oranje2 = false;
            braun2 = false;
            grau2 = false; */
        }
    }



    //Change for Circle A


   

    private void Start()
    {
        changeRed();
        changeBlue();
        changeBrown();
        changeGray();
        changeGreen();
        changeOrange();
        changeYellow();
        NumberOtherA();
        NumberOtherC();
        NumberOtherD();
        otherB();
    }

    void again()
    {
        if (CircleA.clicked == true)
        {
            changeRed();
            changeBlue();
            changeBrown();
            changeGray();
            changeGreen();
            changeOrange();
            changeYellow();
            NumberOtherA();
            NumberOtherC();
            NumberOtherD();
            otherB();
            CircleA.clicked = false;
        }
    }

    private void Update()
    {
        Retry();
        again();
    }

}
