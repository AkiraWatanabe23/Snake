using UnityEngine;
using Constants;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _score = 0;

    private float _timer = Consts.GAME_TIME;

    private void Start()
    {
        
    }

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            //制限時間内にクリアできなければ失敗
        }
    }
}
