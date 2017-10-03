//Skript für den dritten Kreis.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleC : MonoBehaviour
{
    public bool fault = false;
    public static bool scoreC = false;
    public static bool rot3 = false;
    public static bool blau3 = false;
    public static bool grün3 = false;
    public static bool gelb3 = false;
    public static bool oranje3 = false;
    public static bool braun3 = false;
    public static bool grau3 = false;


    //selbes für die anderen "Other"s
    void NumberOtherA()
    {
        if (Mittelpunkt.red3 == true || Mittelpunkt.blue3 == true || Mittelpunkt.yellow3 == true || Mittelpunkt.green3 == true || Mittelpunkt.gray3 == true || Mittelpunkt.orange3 == true || Mittelpunkt.brown3 == true)
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

    void NumberOtherB()
    {
        if (Mittelpunkt.red3 == true || Mittelpunkt.blue3 == true || Mittelpunkt.yellow3 == true || Mittelpunkt.green3 == true || Mittelpunkt.gray3 == true || Mittelpunkt.orange3 == true || Mittelpunkt.brown3 == true)
        {
            System.Random Num = new System.Random();
            int a = Num.Next(0, 7);

            if (a == 0)
            {
                CircleB.rot2 = true;
            }
            else if (a == 1)
            {
                CircleB.blau2 = true;
            }
            else if (a == 2)
            {
                CircleB.grün2 = true;
            }
            else if (a == 3)
            {
                CircleB.gelb2 = true;
            }
            else if (a == 4)
            {
                CircleB.oranje2 = true;
            }
            else if (a == 5)
            {
                CircleB.braun2 = true;
            }
            else if (a == 6)
            {
                CircleB.grau2 = true;
            }
        }
    }

    void NumberOtherD()
    {
        if (Mittelpunkt.red3 == true || Mittelpunkt.blue3 == true || Mittelpunkt.yellow3 == true || Mittelpunkt.green3 == true || Mittelpunkt.gray3 == true || Mittelpunkt.orange3 == true || Mittelpunkt.brown3 == true)
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
        if (Mittelpunkt.red3 == true || Mittelpunkt.blue3 == true || Mittelpunkt.yellow3 == true || Mittelpunkt.green3 == true || Mittelpunkt.orange3 == true || Mittelpunkt.brown3 == true || Mittelpunkt.gray3 == true)
        {
            scoreC = true;
            CircleA.clicked = true;
            Mittelpunkt.red3 = false;
            Mittelpunkt.blue3 = false;
            Mittelpunkt.yellow3 = false;
            Mittelpunkt.green3 = false;
            Mittelpunkt.orange3 = false;
            Mittelpunkt.brown3 = false;
            Mittelpunkt.gray3 = false;
        }
        else if (Mittelpunkt.red3 != true && Mittelpunkt.blue3 != true && Mittelpunkt.yellow3 != true && Mittelpunkt.green3 != true && Mittelpunkt.orange3 != true && Mittelpunkt.brown3 != true && Mittelpunkt.gray3 != true)
        {
            Application.LoadLevel(2);
        }

    }

    

   

    //Test! noch nicht final!
    public void changeRed()
    {
        if (Mittelpunkt.red3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.red);
            NumberOtherA();
        }
    }

    public void changeBlue()
    {
        if (Mittelpunkt.blue3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.blue);
            NumberOtherA();
        }
    }

    public void changeGreen()
    {
        if (Mittelpunkt.green3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.green);
            NumberOtherA();
        }
    }

    public void changeYellow()
    {
        if (Mittelpunkt.yellow3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
            NumberOtherA();
        }
    }

    public void changeOrange()
    {
        if (Mittelpunkt.orange3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.black);
            NumberOtherA();
        }
    }

    public void changeBrown()
    {
        if (Mittelpunkt.brown3 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.black);
            NumberOtherA();
        }
    }

    public void changeGray()
    {
        if (Mittelpunkt.gray3 == true)
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
    void otherC()
    {
        if (Mittelpunkt.red3 != true && Mittelpunkt.blue3 != true && Mittelpunkt.yellow3 != true && Mittelpunkt.gray3 != true && Mittelpunkt.green3 != true && Mittelpunkt.orange3 != true && Mittelpunkt.brown3 != true)
        {
            Renderer REND = GetComponent<Renderer>();
            REND.material.shader = Shader.Find("GUI/Text Shader");
            REND.material.SetColor("_Color", Color.white);
            if (Mittelpunkt.red2 == true || Mittelpunkt.red1 == true || Mittelpunkt.red4 == true)
            {
                if (rot3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
                else if (blau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.blue2 == true || Mittelpunkt.blue1 == true || Mittelpunkt.blue4 == true)
            {
                if (rot3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (grün3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.green2 == true || Mittelpunkt.green1 == true || Mittelpunkt.green4 == true)
            {
                if (rot3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (gelb3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.yellow2 == true || Mittelpunkt.yellow1 == true || Mittelpunkt.yellow4 == true)
            {
                if (rot3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (oranje3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.orange2 == true || Mittelpunkt.orange1 == true || Mittelpunkt.orange4 == true)
            {
                if (rot3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (braun3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.brown2 == true || Mittelpunkt.brown1 == true || Mittelpunkt.brown4 == true)
            {
                if (rot3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.gray2 == true || Mittelpunkt.gray1 == true || Mittelpunkt.gray4 == true)
            {
                if (rot3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau3 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
            }
         /*   rot3 = false;
            blau3 = false;
            grün3 = false;
            gelb3 = false;
            oranje3 = false;
            braun3 = false;
            grau3 = false; */
        }
    }
   

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
        NumberOtherB();
        NumberOtherD();
        otherC();
      
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
            NumberOtherB();
            NumberOtherD();
            otherC();
            CircleA.clicked = false;
        }
    }

    private void Update()
    {
        Retry();
        again();
    }

}
