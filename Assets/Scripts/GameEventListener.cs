using UnityEngine;

[ExecuteInEditMode] // Runs this Script (Update) in Edit Mode
public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameAction[] actions;

    // Updates the title of each element to attached Scriptable Object name
    private void Update()
    {
        if (Application.isEditor)
        {
            foreach (var action in actions)
            {
                action.Update();
            }
        }
    }

    // Registers all actions to their respective listeners
    private void OnEnable()
    {
        foreach (var action in actions)
        {
            action.RegisterListener();
        }
    }

    // UnRegisters all actions
    private void OnDisable() // 5
    {
        foreach (var action in actions)
        {
            action.UnRegisterListener();
        }
    }
}