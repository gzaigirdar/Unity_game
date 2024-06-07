using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ob : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] float movespeed;
    //[SerializeField] float collectableYOffset = 2.0f;

     private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
     /*if (gameObject.CompareTag("Collectable"))
        {
            // Offset the y value
            Vector3 position = transform.position;
            position.y += collectableYOffset;
            transform.position = position;
        }
        */
        rb.velocity = Vector2.left * movespeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -15f){
            Destroy(gameObject);

        }
    }
}
