using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerupBehavior : MonoBehaviour
{
    public PlayerController _playerController;

    [SerializeField]
    private float powerUpStrenght = 5, rotateSpeed = 200;

    private void Start()
    {
        //_playerController = FindObjectOfType(PlayerController);
        rotateSpeed = 200;  
    }

    void Update()
    {
        RotatingPowerups();
    }

    //objectpooling?
    private void OnTriggerEnter(Collider other)
    {
        Powerup();

        Destroy(this.gameObject);
    }

    void RotatingPowerups()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }

    void Powerup()
    {
        _playerController.Acceleration = powerUpStrenght;
    }




}