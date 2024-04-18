using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public static gamemanager instance;

    private void Awake(){
        instance = this;

    }
    public void Gameover(){
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
