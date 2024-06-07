using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    
    public TMP_Text text;
    int counter = 0;

    
    public void score_update(){
        counter++;
        text.text = counter.ToString();

    }


}
