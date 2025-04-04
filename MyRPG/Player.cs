using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Player
{
    private int xp;
    private float health;
    public string Name {get;}

    public int XP
    {
        get
        {
            return xp;
        }
        set
        {
        xp += value;
        }
    }

    public int Level
    {
        get { return 1+xp/1000; }
    }

    public float Health
    {
        get
        {
            return health;
        }
        set
        {
            if ( value < 0 )
            {
                health = 0;
            }
            else if ( value > MaxHealth )
            {
                health = MaxHealth;
            }
            else
            {
                health = value;
            }
        }
    }

    public float MaxHealth
    {
        get { return 100+(Level - 1)*20; }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        XP = (int)damage/20;
    }

    public Player(string Name)
    {
        this.Name = Name;
        xp = 0;
        Health = MaxHealth;
    }
}