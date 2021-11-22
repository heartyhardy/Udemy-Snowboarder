using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleCrash : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Snow"){
            Invoke("ReloadScene", 1f);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene("World");
    }
}
