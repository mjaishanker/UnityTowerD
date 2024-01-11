using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GenericSerializeDictionary<TKey, TValue> : Dictionary<TKey, TValue>
{
    [SerializeField]
    private GenericSerializeDictItem<TKey, TValue>[] _thisDictItem;
}

[Serializable]
public class GenericSerializeDictItem<TKey, TValue>
{
    [SerializeField]
    private TKey _tkey;
    [SerializeField]
    private TValue _tvalue;
    
    public TKey _TKey { get { return _tkey; } }
    public TValue _TValue { get { return _tvalue; } }
}

