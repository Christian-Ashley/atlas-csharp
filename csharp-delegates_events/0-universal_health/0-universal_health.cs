﻿using System;

/// <summary>
/// class player
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>A player's class</summary>

    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        
        this.maxHp = maxHp;
        this.name = name;
        this.hp = maxHp;
        
    }
    /// <summary>prints health</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
}