using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    [SerializeField] private int armor = 5, health = 100;
        public void TakeDamage(int dmg, int piercingDmg)
    {
        dmg -= armor;
        health -= dmg > 0 ? piercingDmg + dmg : piercingDmg;
        if (health <= 0) { Destroy(gameObject); }
    }
    
    //Drop loot? Loot table? Loot chance?
}
