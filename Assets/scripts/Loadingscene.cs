using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadingscene : MonoBehaviour
{
    // Start is called before the first frame update
   public void Play_Game(){
    SceneManager.LoadSceneAsync(1);
   }
}
