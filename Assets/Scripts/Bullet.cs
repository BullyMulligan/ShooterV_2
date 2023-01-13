using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    //поля с точкой, откуда летит пуля, префабом пули силой, количеством пули и канвасом для передачи количества
    [SerializeField] private Transform _dulo;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _powerShoot=500;
    [SerializeField] private int _bulletsCount = 20;
    [SerializeField] private PlayerCanvas _screenOfBullets;
    
    void Update()
    {
        //если нажата ЛКМ и пуль больше нуля
        if (Input.GetMouseButtonDown(0) && _bulletsCount>0)
        { 
            //создаем пулю, применяем к ней силу и уменьшаем количество пули на 1, запускаем метод shoot
            var bullet = Instantiate(_bullet, _dulo.transform.position,_dulo.localRotation);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward*_powerShoot,ForceMode.Impulse);
            _bulletsCount--;
            Shoot();
        }
    }

    //отправляет данные о количестве пуль в обойме
    void Shoot()
    {
        _screenOfBullets.BulletsCount(_bulletsCount);
    }

    //на старте так же отправляем данные об обойме
    private void Start()
    {
        _screenOfBullets.BulletsCount(_bulletsCount);
    }
}
