using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] gameobject;
    private IEnumerator coroutine;
    private GameObject gb;
    public float waittime = 2.0f;
    public bool shouldContinue = true;  
    
    void Start()
    {
        coroutine = spawner(waittime);
        StartCoroutine(coroutine);
    }

    void Update()

    {
        if(shouldContinue == false){
            stopobstacles();
        }
        
    }
    public void stopobstacles(){
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("obstacle");
        GameObject[] collectables = GameObject.FindGameObjectsWithTag("Collectable");
        if(obstacles != null){
            foreach (GameObject o in obstacles)
           {
            o.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Destroy(o);
           }

        }
        else{
           Debug.Log("object doesn't exist");
        }
        if(collectables != null){
         foreach (GameObject o in collectables)
           {
            o.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Destroy(o);
           }

        }

        
        
    }

    private IEnumerator spawner(float waittime)
    {
        while (shouldContinue)
        {
            yield return new WaitForSeconds(waittime);
            int randomindex = Random.Range(0, gameobject.Length);
            gb = gameobject[randomindex];
            Instantiate(gb, transform.position, Quaternion.identity);
        }
    }
}
