using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleSnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowTrail = null;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Snow"){
            snowTrail.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Snow"){
            snowTrail.Stop();
        }
    }
}
