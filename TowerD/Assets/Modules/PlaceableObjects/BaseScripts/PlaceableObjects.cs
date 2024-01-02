using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceableObjects : ScriptableObject
{
    [Header("Placeable Objects Fields")]
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _description;
    [SerializeField]
    private int _cost;
    [SerializeField]
    private GameObject _placeableObjectPrefab;
    [SerializeField]
    private GameObject _bpPlaceObject;

    public string Name { get { return _name; } }
    public string Description { get { return _description;} }
    public int Cost { get { return _cost;} }
}
