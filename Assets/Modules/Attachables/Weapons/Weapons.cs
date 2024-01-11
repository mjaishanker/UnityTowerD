using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Assets/New Weapon")]
public class Weapons : Attachables
{
    [Header("Weapon Fields")]
    [SerializeField]
    private float _weaponDamage = 10;

    public float WeaponDamage { get { return _weaponDamage; } }
}
