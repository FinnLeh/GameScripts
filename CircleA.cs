//Skript für den ersten Kreis. 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public static bool rot = false;
    public static bool blau = false;
    public static bool grün = false;
    public static bool gelb = false;
    public static bool oranje = false;
    public static bool braun = false;
    public static bool grau = false; 

    public bool fault = false;
    public static bool score = false;
    public static bool clicked = false;
    

    //Hier NumberOther... für die anderen Circle einfügen!
    void NumberOther(Circle circle, Mittelpunkt mittelpunkt)
    {
        if (mittelpunkt.red || mittelpunkt.blue || mittelpunkt.yellow || mittelpunkt.green || mittelpunkt.gray || mittelpunkt.orange || mittelpunkt.brown)
        {
            System.Random Num = new System.Random();
            int a = Num.Next(0, 7);

            if (a == 0)
            {
                circle.rot = true;
            }
            else if (a == 1)
            {
                circle.blau = true;
            }
            else if (a == 2)
            {
                circle.grün = true;
            }
            else if (a == 3)
            {
                circle.gelb = true;
            }
            else if (a == 4)
            {
                circle.oranje = true;
            }
            else if (a == 5)
            {
                circle.braun = true;
            }
            else if (a == 6)
            {
                circle.grau = true;
            }
        }
    }

    private void OnMouseDown(Mittelpunkt mittelpunkt)
    {
        if (mittelpunkt.red || mittelpunkt.blue || mittelpunkt.yellow || mittelpunkt.green || mittelpunkt.orange || mittelpunkt.brown || Mittelpunkt.gray)
        {
            score = true;
            clicked = true;
            mittelpunkt.red = false;
            mittelpunkt.blue = false;
            mittelpunkt.yellow = false;
            mittelpunkt.green = false;
            mittelpunkt.orange = false;
            mittelpunkt.brown = false;
            mittelpunkt.gray = false;
        } else {
            Application.LoadLevel(2);
        }
    }

    //Mit globalen Variablen?
    //Test! Noch nicht final!
    public void changeRed(Mittelpunkt mittelpunkt)
    {
        if (mittelpunkt.red == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.red);
        }
    }

    public void changeBlue(Mittelpunkt mittelpunkt)
    {
        if (mittelpunkt.blue == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.blue);
        }
    }
    
    public void changeGreen(Mittelpunkt mittelpunkt)
    {
        if (mittelpunkt.green == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.green);
        }
    }

    public void changeYellow(Mittelpunkt mittelpunkt)
    {
        if (mittelpunkt.yellow == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.yellow);
        }
    }

    public void changeOrange(Mittelpunkt mittelpunkt)
    {
        if (mittelpunkt.orange == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.HSVToRGB(229f, 168f, 34f));
        }
    }

    public void changeBrown(Mittelpunkt mittelpunkt)
    {
        if (mittelpunkt.brown == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("GUI/Text Shader");
            rend.material.SetColor("_Color", Color.HSVToRGB(94, 61, 19));
        }
    }

    public void changeGray(Mittelpunkt mittelpunkt)
    {
        if (mittelpunkt.gray == true)
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
