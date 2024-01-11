using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
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

    [SerializeField]
    private List<Attachables> _attachables;

    [SerializeField]
    private GenericSerializeDictionary<Attachables.AttachablesType, TestTest> _attachablesSpawnTransformPoints; 
    
    public string Name { get { return _name; } }
    public string Description { get { return _description;} }
    public int Cost { get { return _cost;} }

    [Serializable]
    private struct AttachableTransformStatus
    {
        [SerializeField]
        public Transform _attachableTransformPoint;
        private bool _isTransformFreeForNewAttachable;
        
        public Transform AttachableTransformPoint { get { return _attachableTransformPoint; } }
        public bool IsTransformFreeForNewAttachable { get { return _isTransformFreeForNewAttachable; } }
    }

    public void ProcessAndAttachAttachables()
    {
        if(_attachables.Count == 0 || _attachablesSpawnTransformPoints.Count == 0 || _attachablesSpawnTransformPoints.Count <= _attachables.Count)
        {
            Debug.LogError("Attachables are not possible for this Placable objects due to NO Attachables present, NO Attachables Transforms, or Number of Attachables for this object is more than the allowed Attachables list");
            return;
        }

        // TODO Code Review, for looping through Data Structure. Maybe a Dictionary for better lookup.
        foreach(Attachables attachable in _attachables)
        {
            if(attachable.AttachablePrefab != null && attachable.BPAttachablePrefab && attachable.AttachableType != null)
            {
                //Transform tempSpawnAttachableTransform;
                //_attachablesSpawnTransformPoints.TryGetValue(attachable.AttachableType, out tempSpawnAttachableTransform);
                //attachable
            }
        }

    }
}


