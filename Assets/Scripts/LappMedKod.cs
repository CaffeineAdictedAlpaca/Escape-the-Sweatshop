using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LappMedKod : Interact
{
    //gjord av max
   
    [SerializeField]
    TextMeshProUGUI keyPadKoden;
    public codePanel keyPadCode;
    
    
    public override void _Interact()//n�r du interactar s� ska texten p� lappen visa random koden
    {
        keyPadKoden.text = keyPadCode.keyPadCode.ToString();
    }
}
