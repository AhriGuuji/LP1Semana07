using System;

public class Player
{
    private float highScore;
    private int playedGames;
    private int wonGames;
    public string Name {get;}

    public int PlayedGames
    {   get {return playedGames; } }

    public int WonGames
    {   get {return wonGames; } }
    public float HighScore
    {
        get
        {
            return highScore;
        }
        set
        {
            if ( value > highScore )
            {
                highScore = value;
            }
        }
    }

    public float WinRate
    {
        get
        {
        if (playedGames == 0)
        {
            return 0;
        }
        else
        {
            return (WonGames/PlayedGames);
        }
        }
    }

    public void PlayGame(bool win)
    {
        playedGames++;
        if (win) wonGames++;
    }

    public Player (string Name)
    {
        this.Name = Name;
        highScore = 0;
        playedGames = 0;
        wonGames = 0;
    }
}