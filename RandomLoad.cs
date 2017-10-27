using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpezialLoadCard : MonoBehaviour {

    public int alteZahl;
    public int neueZahl;

    public static bool card1 = false;
    public static bool card2 = false;
    public static bool card3 = false;
    public static bool card4 = false;
    public static bool card5 = false;

    void Rnd()
    {
        HauptText.start = false;
        card1 = false;
        card2 = false;
        card3 = false;
        card4 = false;
        card5 = false;

        while (neueZahl == alteZahl)
        {
            System.Random Num = new System.Random();
            neueZahl = Num.Next(0, 5);
        }

        if (neueZahl == 0)
        {
            card1 = true;
            alteZahl = neueZahl;
        }
        else if (neueZahl == 1)
        {
            card2 = true;
            alteZahl = neueZahl;
        }
        else if (neueZahl == 2)
        {
            card3 = true;
            alteZahl = neueZahl;
        }
        else if (neueZahl == 3)
        {
            card4 = true;
            alteZahl = neueZahl;
        }
        else if (neueZahl == 4)
        {
            card5 = true;
            alteZahl = neueZahl;
        }
    }
}
