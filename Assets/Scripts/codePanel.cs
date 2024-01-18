using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class codePanel : MonoBehaviour
{
    //gjord av max
    public int keyPadCode;

    [SerializeField]
    TextMeshProUGUI codeText;

    string codeTextValue = ("");

    private void Start()
    {
        keyPadCode = Random.Range(1000, 9999);//g�r en randomKod till safe
        print("test");
    }
    // Update is called once per frame
    void Update()
    {
        
        
        codeText.text = codeTextValue;

        if (codeTextValue == keyPadCode.ToString())//om du klickar in r�tt kod s� �ppnar safe
        {
            safe.isKeyPadOpen = true;
        }
        if (codeTextValue.Length >= 4)//n�r du skrivit 4 siffror s� raderar den siffrorna s� du kan f�rs�ka igen
        {
            codeTextValue = ("");
        }
    }

    public void AddDigit(string digit)//n�r du klickar �kar codeTextValue.length
    {
        codeTextValue += digit;
    }


}
