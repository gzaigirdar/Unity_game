using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    Counter counter_script;
    public GameObject spawner;
    private Spawner sp_script;
    [SerializeField] float jumpForce;
    bool gameover = false;
    bool grounded = false;
    public texturescript textureScript;
    public float min_spawn_time;
    public float mix_spawn_time;
    //public GameObject[] objects ;
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
        sp_script = spawner.GetComponent<Spawner>();
        counter_script = GetComponent<Counter>();
        //objects = GameObject.FindGameObjectsWithTag("obstacle");
        //con = true;
        //spawn();

        
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
        
            
            //con = false;
            sp_script.shouldContinue = false;
           // stopobstacles();
           SceneManager.LoadSceneAsync(2);
            

        }
        if(collision.gameObject.tag == "Collectable"){
            Destroy(collision.gameObject);
            counter_script.score_update();
        }


    }
  
    
   

   
   
}
