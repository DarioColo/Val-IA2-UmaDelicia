using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFSM<TFeed> {

    public State<TFeed> current;
    public void Update() { current.OnUpdate(); }
    public void Feed(TFeed feed)
    {
        var next = current.GetTransition(feed);
        if(next != null)
        {
            current.OnExit();
            current = next;
            current.OnEnter();
        }
    }
    public EventFSM (State<TFeed> initialState)
    {
        current = initialState;
        current.OnEnter();
    }
}
public class State<TFeed>
{
    public Action OnEnter = delegate { };
    public Action OnUpdate = delegate { };
    public Action OnExit = delegate { };

    public Dictionary<TFeed, State<TFeed>> transitions = new Dictionary<TFeed, State<TFeed>>();

    public void AddTransition(TFeed feed, State<TFeed> next)
    {
        transitions[feed] = next;
    }
    public State<TFeed> GetTransition(TFeed feed)
    {
        if (transitions.ContainsKey(feed)) return transitions[feed];
        return null;
    }

}
