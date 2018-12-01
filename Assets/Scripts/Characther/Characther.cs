using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characther : MonoBehaviour {

	public GameObject _bulletPrefab;
	void Start () {
		
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Q)) Shoot();
	}
	void Shoot(){
		GameObject bullet = Instantiate(_bulletPrefab) as GameObject;
		bullet.transform.position = this.transform.position;
		bullet.transform.forward = this.transform.forward;
	}
}
