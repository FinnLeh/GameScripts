//Skript für den ersten Kreis. 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleA : MonoBehaviour
{

    public static bool rot1 = false;
    public static bool blau1 = false;
    public static bool grün1 = false;
    public static bool gelb1 = false;
    public static bool oranje1 = false;
    public static bool braun1 = false;
    public static bool grau1 = false;

    

    public bool fault = false;
    public static bool scoreA = false;
    public static bool clicked = false;
    

    //Hier NumberOther... für die anderen Circle einfügen!
    void NumberOtherB()
    {
        if (Mittelpunkt.red1 == true || Mittelpunkt.blue1 == true || Mittelpunkt.yellow1 == true || Mittelpunkt.green1 == true || Mittelpunkt.gray1 == true || Mittelpunkt.orange1 == true || Mittelpunkt.brown1 == true)
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
        if (Mittelpunkt.red1 == true || Mittelpunkt.blue1 == true || Mittelpunkt.yellow1 == true || Mittelpunkt.green1 == true || Mittelpunkt.gray1 == true || Mittelpunkt.orange1 == true || Mittelpunkt.brown1 == true)
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
        if (Mittelpunkt.red1 == true || Mittelpunkt.blue1 == true || Mittelpunkt.yellow1 == true || Mittelpunkt.green1 == true || Mittelpunkt.gray1 == true || Mittelpunkt.orange1 == true || Mittelpunkt.brown1 == true)
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
        if (Mittelpunkt.red1 == true || Mittelpunkt.blue1 == true || Mittelpunkt.yellow1 == true || Mittelpunkt.green1 == true || Mittelpunkt.orange1 == true || Mittelpunkt.brown1 == true || Mittelpunkt.gray1 == true)
        {
            scoreA = true;
            clicked = true;
            Mittelpunkt.red1 = false;
            Mittelpunkt.blue1 = false;
            Mittelpunkt.yellow1 = false;
            Mittelpunkt.green1 = false;
            Mittelpunkt.orange1 = false;
            Mittelpunkt.brown1 = false;
            Mittelpunkt.gray1 = false;
        }else if (Mittelpunkt.red1 != true && Mittelpunkt.blue1 != true && Mittelpunkt.yellow1 != true && Mittelpunkt.green1 != true && Mittelpunkt.orange1 != true && Mittelpunkt.brown1 != true && Mittelpunkt.gray1 != true)
        {
            Application.LoadLevel(2);
        }
    }

    //Mit globalen Variablen?
    //Test! Noch nicht final!
    public void changeRed()
    {
        if (Mittelpunkt.red1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.red);
        }
    }

    public void changeBlue()
    {
        if (Mittelpunkt.blue1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.blue);
        }
    }
    
    public void changeGreen()
    {
        if (Mittelpunkt.green1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.green);
        }
    }

    public void changeYellow()
    {
        if (Mittelpunkt.yellow1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
        }
    }

    public void changeOrange()
    {
        if (Mittelpunkt.orange1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.HSVToRGB(229f, 168f, 34f));
        }
    }

    public void changeBrown()
    {
        if (Mittelpunkt.brown1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.HSVToRGB(94, 61, 19));
        }
    }

    public void changeGray()
    {
        if (Mittelpunkt.gray1 == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.gray);
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


    public void OtherA()
    {
        if (Mittelpunkt.red1 != true && Mittelpunkt.blue1 != true && Mittelpunkt.yellow1 != true && Mittelpunkt.gray1 != true && Mittelpunkt.green1 != true && Mittelpunkt.orange1 != true && Mittelpunkt.brown1 != true)
        {
            Renderer REND = GetComponent<Renderer>();
            REND.material.shader = Shader.Find("GUI/Text Shader");
            REND.material.SetColor("_Color", Color.white);
            if (Mittelpunkt.red2 == true || Mittelpunkt.red3 == true || Mittelpunkt.red4 == true)
            {
                if (rot1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
                else if (blau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.blue2 == true || Mittelpunkt.blue3 == true || Mittelpunkt.blue4 == true)
            {
                if (rot1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (grün1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.green2 == true || Mittelpunkt.green3 == true || Mittelpunkt.green4 == true)
            {
                if (rot1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (gelb1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.yellow2 == true || Mittelpunkt.yellow3 == true || Mittelpunkt.yellow4 == true)
            {
                if (rot1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (oranje1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.orange2 == true || Mittelpunkt.orange3 == true || Mittelpunkt.orange4 == true)
            {
                if (rot1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (braun1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.brown2 == true || Mittelpunkt.brown3 == true || Mittelpunkt.brown4 == true)
            {
                if (rot1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.gray);
                }
            }
            else if (Mittelpunkt.gray2 == true || Mittelpunkt.gray3 == true || Mittelpunkt.gray4 == true)
            {
                if (rot1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.red);
                }
                else if (blau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.blue);
                }
                else if (grün1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.green);
                }
                else if (gelb1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.yellow);
                }
                else if (oranje1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (braun1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
                else if (grau1 == true)
                {
                    Renderer rend = GetComponent<Renderer>();
                    rend.material.shader = Shader.Find("GUI/Text Shader");
                    rend.material.SetColor("_Color", Color.black);
                }
            }
           /* rot1 = false;
            blau1 = false;
            grün1 = false;
            gelb1 = false;
            oranje1 = false;
            braun1 = false;
            grau1 = false; */
        }
    }


    private void again()
    {
        if (clicked == true)
        {
            changeBlue();
            changeBrown();
            changeGray();
            changeGreen();
            changeOrange();
            changeRed();
            changeYellow();
            NumberOtherB();
            NumberOtherC();
            NumberOtherD();
            OtherA();
            clicked = false;
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
        NumberOtherB();
        NumberOtherC();
        NumberOtherD();
        OtherA();
    }

    private void Update()
    {
        again();
        Retry();
    }

}
