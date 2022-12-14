using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpItem : MonoBehaviour
{
    /// <summary>弾のタグの名前</summary>
    [SerializeField] string _tagName;
    [SerializeField] GameObject _heartPrefab;
    GameObject _heartPanel;
    Gamemanager _gamemanager;
    [Header("弾速")]
    [SerializeField] bool _isBulletvelocity;
    [Header("間隔")]
    [SerializeField] bool _isinterval;
    [Header("Hp")]
    [SerializeField] bool _isHp;

    [Header("減らす秒数")]
    [SerializeField] float _time;

    [SerializeField] float _maxSpeed;
    [SerializeField] float _maxbullet;
    [SerializeField] int _maxHp;
    [SerializeField] int _score;
    PlayerScript _player;
    private void Start()
    {
        _player = GameObject.FindObjectOfType<PlayerScript>();
        _gamemanager = GameObject.FindObjectOfType<Gamemanager>();
        _heartPanel = GameObject.Find("HeartPanel");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _tagName)
        {
            //弾速
            if (_isBulletvelocity)
            {
                if (BulletScript._speed <= _maxSpeed)
                {
                    BulletScript._speed *= 1.2f;
                }
                else
                {
                    Gamemanager.AddScore(_score);
                }
                Destroy(gameObject);
            }
            //インターバル変更
            else if (_isinterval)
            {
                if (_player._maxBullet <= _maxbullet)
                {
                    _player._maxBullet += 10 ;
                }
                else
                {
                    Gamemanager.AddScore(_score);
                }
                Destroy(gameObject);
            }
            //HP
            else if (_isHp)
            {
                if (PlayerScript._playerHp <= _maxHp)
                {
                    PlayerScript._playerHp++; 
                }
                else
                {
                    Gamemanager.AddScore(_score);
                }
                Destroy(gameObject);
            }
        }
    }
}
