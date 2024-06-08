using System;
using UnityEngine;

public class LeaderboardUI : WindowUI
{
    public new event Action OnPlayAudioUI;

    public void AddScore(int newHighScore) {
    }

    public void OnEnable()
    {
    }
    public override void PlayAudioUI()
    {
        OnPlayAudioUI();
    }
}
