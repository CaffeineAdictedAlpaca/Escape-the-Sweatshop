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
    
    
    public override void _Interact()//när du interactar så ska texten på lappen visa random koden
    {
        keyPadKoden.text = keyPadCode.keyPadCode.ToString();
    }
}
