using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * 10 * Time.deltaTime;
	}
	void OnCollisionEnter(Collision c){
		//Enemy _enemy = c.GetComponent<Enemy>();
		//if(_enemy) _enemy.hp --;
	}
}
