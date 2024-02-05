using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    public Gun() : base() 
    {
        base.weaponName = "TommyGun";
        weaponStrength = 700;
    }

    public Gun(string wName)
    {
        weaponName = wName;
        weaponStrength += 10;
    }
}
