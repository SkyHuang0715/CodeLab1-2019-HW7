using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyDemo : MonoBehaviour {
 
    //每个砖块的自动销毁脚本
 
    //AudioSource asbro;
    // Use this for initialization
    void Start () {
        //asbro = GetComponent<AudioSource>();
    }
	
    // Update is called once per frame
    void Update () {
		
    }
 
    private void OnCollisionEnter(Collision collision)
    {
        //asbro.Play();
        Destroy(this.gameObject,0.05f);   //碰撞后 0.05s销毁自身
    }
}

