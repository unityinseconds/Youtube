using UnityEngine;

[CreateAssetMenu(fileName = "NewStats", menuName = "Stats/Player Stats")]
public class PlayerStats : ScriptableObject
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int Heaslth;
    public int Mana;
}
