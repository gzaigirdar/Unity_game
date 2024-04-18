using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] float jumpForce;
    bool gameover = false;
    bool grounded = false;
    public texturescript textureScript;
    public float min_spawn_time;
    public float mix_spawn_time;
    public GameObject[] objects ;
    public bool con;

 

    
    
    public void Awake(){

        GameObject  texturegb = GameObject.Find("bg");
        if(texturegb != null){
            textureScript = texturegb.GetComponent<texturescript>();

        }
        

    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        objects = GameObject.FindGameObjectsWithTag("obstacle");
        con = true;
        spawn();

        
    }
    // jump function for the player 
    void Jump(){
        grounded = false;
        rb.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && !gameover){
            if(grounded){
                Jump();
            }
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collison) {
        if (collison.gameObject.tag == "Ground"){
            grounded = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject.tag == "obstacle"){
            Destroy(gameObject);
            gameover = true;
            if(textureScript != null){
                textureScript.stopscrolling();

            }
        
            stopobstacles();
            con = false;
            

        }


    }
     public void stopobstacles(){
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("obstacle");
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
        
        
    }
    // ienumarator is custom itarator 
    IEnumerator spawn(){
        float waittime = 1f;
        

        while(con){
            create_objects();
            yield return new WaitForSeconds(waittime);
        }
    }

    void create_objects(){
        // generating a random number index  the obstecle array 
        int random = Random.Range(0,objects.Length);
        // quterian.identiy adds zero rotation by default
        
        Vector2 position = new Vector2(transform.position.x,transform.position.y);
        Vector2 spawnpoint = position + Vector2.right * 1.0f;

        Instantiate(objects[random],position,Quaternion.identity);


    }
   
}
