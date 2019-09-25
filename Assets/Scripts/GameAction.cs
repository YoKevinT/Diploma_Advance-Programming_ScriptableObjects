using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class GameAction
{
    [HideInInspector] public string name;
    public GameEvent gameEvent;
    // The UnityEvent response that will be invoked when the GameEvent raises this GameEventListener.
    public UnityEvent gameAction;

    public void Update()
    {
        if (gameEvent)
        {
            name = gameEvent.name;
        }
    }

    //Register the GameEvent to the GameEventListener when this GameObject is enabled
    public void RegisterListener()
    {
        gameEvent.RegisterListener(this);
    }

    // Unregister the GameEvent from the GameEventListener when this GameObject is disabled
    public void UnRegisterListener()
    {
        gameEvent.RegisterListener(this);
    }

    // Called when a GameEvent is raised causing the GameEventListener to invoke the UnityEvent
    public void OnEventRaised()
    {
        gameAction.Invoke();
    }
}