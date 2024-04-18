using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texturescript : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollspeed;
    public bool scroll = true;
    Material backgroundMaterial;

   private void  Awake() {
        backgroundMaterial = GetComponent<Renderer>().material;
    }
    private void  FixedUpdate() {
        if(scroll){
            Vector2 offset = new Vector2(scrollspeed * Time.time,0);
            backgroundMaterial.mainTextureOffset = offset;
        }
    }

    public void stopscrolling(){
        scroll = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
