using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tower", menuName = "Assets/New Tower")]
public class BaseTower : PlaceableObjects
{
    [Header("Tower Fields")]
    [SerializeField]
    private float _towerRange = 1f;

    public float TowerRange { get { return _towerRange; } }
}
