using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBox : MonoBehaviour
{
    [SerializeField] private GameObject _setObj = default;

    private void Start()
    {
        
    }

    private void Update()
    {
        //左クリックで生成
        if (Input.GetMouseButtonDown(0))
        {
            var inputPos = Input.mousePosition;
            inputPos.z = 10f;
            Instantiate(_setObj, Camera.main.ScreenToWorldPoint(inputPos), Quaternion.identity);
        }
    }
}
