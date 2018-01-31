using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour {

    public int Duration { private set { Duration = value; } get { if (Status == MatchStatus.inProgress) { return (int)(Time.time - _startTime); } else { return Duration; } } }
    private float _startTime;

    public int Turn { private set; get; }

    private ForcePlayer _playerOne;

    private ForcePlayer _playerTwo;

    public ForcePlayer TurnPlayer { private set; get; }

    public ForcePlayer Winner { private set; get; }

    public ForcePlayer Loser { private set; get; }

    public MatchStatus Status { private set; get; }

    public void Start()
    {
        Status = MatchStatus.ready;
    }

    public void StartMatch(ForcePlayer playerOne, ForcePlayer playerTwo)
    {
        _playerOne = playerOne;
        _playerTwo = playerTwo;
        Status = MatchStatus.inProgress;
        _startTime = Time.time;
    }

    public void EndTurn(ForcePlayer player)
    {
        //Check if it's the players Turn
        if (player != TurnPlayer)
            return;

        TurnPlayer = player;

        _playerOne.IsTurnPLayer = !_playerOne.IsTurnPLayer;
        _playerTwo.IsTurnPLayer = !_playerTwo.IsTurnPLayer;

        //Increment Turn
        Turn++;
    }

    public void LoseGame(ForcePlayer player)
    {
        Duration = (int)(Time.time - _startTime);
        Status = MatchStatus.hasEnded;
        Winner = player;
        if (Winner != _playerOne)
            Loser = _playerOne;
        else
            Loser = _playerTwo;

        
    }


}
