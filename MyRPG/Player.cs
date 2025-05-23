using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace MyRPG
{
public class Player
{
    private int xp;
    private float health;
    public string Name {get;} //readonly auto-implanted

    //get xp or add to xp
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

    //get Level
    public int Level
    {
        get { return 1+xp/1000; }
    }

    //GetHealth or SetHealth between the break

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

    //Get MaxHealth
    public float MaxHealth
    {
        get { return 100+(Level - 1)*20; }
    }

    //Take damage and increment xp
    public void TakeDamage(float damage)
    {
        health -= damage;
        XP = (int)damage/20;
    }

    //Constructor
    public Player(string Name)
    {
        this.Name = Name;
        xp = 0;
        Health = MaxHealth;
    }
}
}