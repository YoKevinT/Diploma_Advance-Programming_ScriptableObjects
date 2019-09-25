using UnityEngine;

[CreateAssetMenu(fileName = "New SwordData", menuName = "Sword Data", order = 51)]
public class SwordData : ScriptableObject
{
    // Contain all the data, corresponding with the information displayed
    [SerializeField] private string swordName;
    [SerializeField] private string description;
    [SerializeField] private Sprite icon;
    [SerializeField] private int goldCost;
    [SerializeField] private int attackDamage;

    // This is so that other scripts can access the private fields inside your ScriptableObject
    public string SwordName
    {
        get
        {
            return swordName;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public Sprite Icon
    {
        get
        {
            return icon;
        }
    }

    public int GoldCost
    {
        get
        {
            return goldCost;
        }
    }

    public int AttackDamage
    {
        get
        {
            return attackDamage;
        }
    }
}