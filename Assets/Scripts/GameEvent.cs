using System.Collections.Generic;
using UnityEngine;

// Adds the GameEvent as an asset on your asset menu
[CreateAssetMenu(fileName = "New Game Event", menuName = "Game Event", order = 52)]
public class GameEvent : ScriptableObject
{
    private List<GameAction> listeners = new List<GameAction>();

    public void Raise()
    {
        // The last GameEventListener to be subscribed will be the first to get invoked (last in, first out)
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            // Invokes each GameEventListeners UnityEvent
            listeners[i].OnEventRaised();
        }
    }

    // A method to allow GameEventListeners to subscribe and unsuscribe to this GameEvent 
    public void RegisterListener(GameAction listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(GameAction listener)
    {
        listeners.Remove(listener);
    }
}
