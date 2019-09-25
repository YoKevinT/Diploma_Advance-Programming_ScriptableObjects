using UnityEngine;
using UnityEngine.Events;

public class Sword : MonoBehaviour
{
    // Data container for this sword’s data
    //[SerializeField] private SwordData swordData;
    [SerializeField] private UnityEvent onMouseDown;

    private void OnMouseDown()
    {
        /// Examples of how to retrieve the data from your ScriptableObject asset
        //Debug.Log(swordData.SwordName);
        //Debug.Log(swordData.Description);
        //Debug.Log(swordData.Icon.name);
        //Debug.Log(swordData.GoldCost);
        //Debug.Log(swordData.AttackDamage);

        onMouseDown.Invoke();
    }
}