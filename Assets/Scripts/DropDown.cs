using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DropDown : MonoBehaviour
{
    public TextMeshProUGUI output;

    public void HandeInputData(int val)
    {
        if(val == 0)
        {
            output.text = "Optional A";
        }

        if (val == 1)
        {
            output.text = "Optional B";
        }

        if (val == 2)
        {
            output.text = "Optional C";
        }
    }

    
}
