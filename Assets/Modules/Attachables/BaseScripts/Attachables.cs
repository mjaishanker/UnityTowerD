using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachables : ScriptableObject
{
    [Header("Attachables Fields")]
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _description;
    [SerializeField]
    private AttachablesType _attachableType;
    [SerializeField]
    private int _cost;
    [SerializeField]
    private GameObject _attachablePrefab;
    [SerializeField]
    private GameObject _bpAttachableObject;

    public string Name { get { return _name; } }
    public string Description { get { return _description; } }
    public AttachablesType? AttachableType { get { return _attachableType; } }
    public int Cost { get { return _cost; } }
    public GameObject AttachablePrefab { get { return _attachablePrefab; } }
    public GameObject BPAttachablePrefab { get { return _attachablePrefab; } }

    public enum AttachablesType
    {
        Weapon,
        Defense,
        Utility,
        Support
    }

}

