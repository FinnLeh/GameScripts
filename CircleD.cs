//Skript für den vierten Kreis.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleD : MonoBehaviour
{

    public bool fault = false;
    public static bool scoreD = false;
    public static bool rot4 = false;
    public static bool blau4 = false;
    public static bool grün4 = false;
    public static bool gelb4 = false;
    public static bool oranje4 = false;
    public static bool braun4 = false;
    public static bool grau4 = false;


    //selbes für die anderen "Other"s
    void NumberOtherA()
    {
        if (Mittelpunkt.red4 == true || Mittelpunkt.blue4 == true || Mittelpunkt.yellow4 == true || Mittelpunkt.green4 == true || Mittelpunkt.gray4 == true || Mittelpunkt.orange4 == true || Mittelpunkt.brown4 == true)
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
        if (Mittelpunkt.red4 == true || Mittelpunkt.blue4 == true || Mittelpunkt.yellow4 == true || Mittelpunkt.green4 == true || Mittelpunkt.gray4 == true || Mittelpunkt.orange4 == true || Mittelpunkt.brown4 == true)
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

    void NumberOtherC()
    {
        if (Mittelpunkt.red4 == true || Mittelpunkt.blue4 == true || Mittelpunkt.yellow4 == true || Mittelpunkt.green4 == true || Mittelpunkt.gray4 == true || Mittelpunkt.orange4 == true || Mittelpunkt.brown4 == true)
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


    private void OnMouseDown()
    {
        if (Mittelpunkt.red4 == true || Mittelpunkt.blue4 == true || Mittelpunkt.yellow4 == true || Mittelpunkt.green4 == true || Mittelpunkt.orange4 == true || Mittelpunkt.brown4 == true || Mittelpunkt.gray4 == true)
        {
            scoreD = true;
            CircleA.clicked = true;
            Mittelpunkt.red4 = false;
            Mittelpunkt.blue4 = false;
            Mittelpunkt.yellow4 = false;
            Mittelpunkt.green4 = false;
            Mittelpunkt.orange4 = false;
            Mittelpunkt.brown4 = false;
            Mittelpunkt.gray4 = false;
        }
        else if (Mittelpunkt.red4 != true && Mittelpunkt.blue4 != true && Mittelpunkt.yellow4 != true && Mittelpunkt.green4 != true && Mittelpunkt.orange4 != true && Mittelpunkt.brown4 != true && Mittelpunkt.gray4 != true)
        {
            Application.LoadLevel(2);
        }
    }

    
    

    //Test! noch nicht final!
    public void changeRed()
    {
        if (Mittelpunkt.red4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.red);
            NumberOtherA();
        }
    }

    public void changeBlue()
    {
        if (Mittelpunkt.blue4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.blue);
            NumberOtherA();
        }
    }

    public void changeGreen()
    {
        if (Mittelpunkt.green4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.green);
            NumberOtherA();
        }
    }

    public void changeYellow()
    {
        if (Mittelpunkt.yellow4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
            NumberOtherA();
        }
    }

    public void changeOrange()
    {
        if (Mittelpunkt.orange4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.black);
            NumberOtherA();
        }
    }

    public void changeBrown()
    {
        if (Mittelpunkt.brown4 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.black);
            NumberOtherA();
        }
    }

    public void changeGray()
    {
        if (Mittelpunkt.gray4 == true)
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
            NumberOtherA();
            RETRYauswirkung.retry = false;
        }
    }


    //die, wenn es nicht die richtige Farbe ist.
    void otherD()
    {
        if (Mittelpunkt.red4 != true && Mittelpunkt.blue4 != true && Mittelpunkt.yellow4 != true && Mittelpunkt.gray4 != true && Mittelpunkt.green4 != true && Mittelpunkt.orange4 != true && Mittelpunkt.brown4 != true)
        {
            Renderer REND = GetComponent<Renderer>();
            REND.material.shader = Shader.Find("GUI/Text Shader");
            REND.material.SetColor("_Color", Color.white);
            if (Mittelpunkt.red2 == true || Mittelpunkt.red1 == true || Mittelpunkt.red3 == true)
            {
                if (rot4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
                else if (blau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.blue2 == true || Mittelpunkt.blue1 == true || Mittelpunkt.blue3 == true)
            {
                if (rot4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (grün4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.green2 == true || Mittelpunkt.green1 == true || Mittelpunkt.green3 == true)
            {
                if (rot4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (gelb4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.yellow2 == true || Mittelpunkt.yellow1 == true || Mittelpunkt.yellow3 == true)
            {
                if (rot4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (oranje4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.orange2 == true || Mittelpunkt.orange1 == true || Mittelpunkt.orange3 == true)
            {
                if (rot4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (braun4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.brown2 == true || Mittelpunkt.brown1 == true || Mittelpunkt.brown3 == true)
            {
                if (rot4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.gray2 == true || Mittelpunkt.gray1 == true || Mittelpunkt.gray3 == true)
            {
                if (rot4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau4 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
            }
         /*   rot4 = false;
            blau4 = false;
            grün4 = false;
            gelb4 = false;
            oranje4 = false;
            braun4 = false;
            grau4 = false; */
        }
    }


    private void Update()
    {
        again();
        Retry();
    }

    private void Start()
    {
        NumberOtherA();
        NumberOtherB();
        NumberOtherC();
        changeYellow();
        changeRed();
        changeOrange();
        changeGreen();
        changeGray();
        changeBrown();
        changeBlue();
        otherD();
    }

    void again()
    {
        if (CircleA.clicked == true)
        {
            changeBlue();
            changeBrown();
            changeGray();
            changeGreen();
            changeOrange();
            changeRed();
            changeYellow();
            NumberOtherA();
            NumberOtherB();
            NumberOtherC();
            otherD();
            CircleA.clicked = false;
        }
    }

}
