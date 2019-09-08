using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollider : MonoBehaviour
{
	public GameObject fire;
	private GameObject audio;
	private AudioSource sound;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player"){
        	//fire=GameObject.Find("/ResidentialHouse4empty/Interior/Fireplace");
            audio=fire.transform.GetChild(0).gameObject;
            sound=audio.GetComponent<AudioSource>();
            sound.enabled=true;
        }
        //Destroy(gameObject);
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player"){
        	//fire=GameObject.Find("/ResidentialHouse4empty/Interior/Fireplace");
            audio=fire.transform.GetChild(0).gameObject;
            sound=audio.GetComponent<AudioSource>();
            sound.enabled=false;
        }
        //Destroy(gameObject);
    }

}
