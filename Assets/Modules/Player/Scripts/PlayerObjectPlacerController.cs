using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerObjectPlacerController : MonoBehaviour
{
    [SerializeField]
    private GameObject _placeableTestTower;
    

    [SerializeField]
    private KeyCode _placeTestObjectKeyCode = KeyCode.Keypad0;

    private GameObject _currentPlaceableObject;
    private float _mouseWheelRotation;

    private void Update()
    {
        HotKeyHandler();
        
        if(_currentPlaceableObject != null)
        {
            MoveCurrentPlaceableObjectToMousePosition();
            RotateFromMouseInput();
            ReleaseIfClicked();
        }
    }

    private void MoveCurrentPlaceableObjectToMousePosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo))
        {
            if(hitInfo.transform.tag == "BuildableZone")
            {
                _currentPlaceableObject.transform.position = hitInfo.point;
                _currentPlaceableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
            }
        }

    }

    private void ReleaseIfClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentPlaceableObject = null;
        }
    }

    private void RotateFromMouseInput()
    {
        _mouseWheelRotation = Input.mouseScrollDelta.y;
        _currentPlaceableObject.transform.Rotate(Vector3.up, _mouseWheelRotation * 10f);
    }


    private void HotKeyHandler() 
    {
        if (Input.GetKeyDown(_placeTestObjectKeyCode))
        {
            if(_currentPlaceableObject == null) 
            {
                _currentPlaceableObject = Instantiate(_placeableTestTower);
            }
            else
            {
                Destroy(_currentPlaceableObject);
            }
        } 
    }

}
