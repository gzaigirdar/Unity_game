using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Gamemanager instance;
    public texturescript texturescript;

    private void Awake(){
        /*if(instance ==  null){
            instance = this;
        } */
    }
    
    public void GameOver(){


    }

    /*public void stopobstacles(){
        GameObject[] obstacles = Gameobject.FindGameObjectWithTag("obstacle");

        foreach (GameObject o in obstacles)
        {
            o.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        
    } */
    

    

}
