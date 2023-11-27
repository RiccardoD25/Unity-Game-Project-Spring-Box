using UnityEngine;
using System.Collections;

public class BoxSound : MonoBehaviour
{
    
    void OnCollisionEnter() //Plays Sound whenever collsion detected
    {
        GetComponent<AudioSource>().Play();
    }
    
}
