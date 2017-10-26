using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour
{
    public GameObject ball;
    public Animation anim;



	// Use this for initialization
	void Start ()
    {
        ball = GameObject.Find("Cannon");
        anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        anim.Play("Cannonfiring");
	}
}
