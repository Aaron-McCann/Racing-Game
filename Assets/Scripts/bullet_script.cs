using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet_script : MonoBehaviour
{
    public ParticleSystem Explosion;    
    // If collision, create explosion effect and then destroys itself
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Racer"){
            ParticleSystem explosionInstant = Instantiate(Explosion, this.transform.position, Quaternion.identity );
            Destroy(this.gameObject);
            FindObjectOfType<ReplayMenu>().collision();
        }
        else if(other.gameObject.tag == "Traffic"){
            ParticleSystem explosionInstant = Instantiate(Explosion, this.transform.position, Quaternion.identity );
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
