using System.Collections.Generic;
using UnityEngine;

/// <summary> ランダムなアイテムを一定時間ごとにスポーンする </summary>
public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _item = default;
    [SerializeField] private List<Transform> _spawnPos = new();
    [SerializeField] private float _interval = 5f;

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            _spawnPos.Add(transform.GetChild(i));
        }

        //ItemSpawn()を_interval(s)後に呼び出し、その後_interval(s)間隔で実行する
        InvokeRepeating(nameof(ItemSpawn), _interval, _interval);
    }

    private void ItemSpawn()
    {
        foreach (var spawn in _spawnPos)
        {
            //スポーン位置の子オブジェクトがなければ(その位置にアイテムがなければ)
            //if (spawn.childCount == 0)
            //{
            //    var go = Instantiate(_item);
            //    go.transform.position = spawn.position;
            //    //出現したアイテムを、その位置の子オブジェクトにする
            //    go.transform.SetParent(spawn);
            //}

            if (!spawn.GetChild(0).gameObject.activeSelf)
            {
                spawn.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}