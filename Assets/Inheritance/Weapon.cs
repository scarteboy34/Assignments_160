using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon 
{
   protected private string weaponName;
   protected private int weaponStrength;

  protected virtual  private void UseWeapon(int damage)
    {
        weaponStrength -= damage;
    }
}
