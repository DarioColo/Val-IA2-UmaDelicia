using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour {

    public event Action<Event> OnEvent = delegate { };

	void Update () {
		//if(booleanos)
	}
}
public enum Event
{
    onPatrol,
    offPatrol,
    onChase,
    offChase,
    onAlert,
    offAlert,
    onAttack,
    offAttack
}
