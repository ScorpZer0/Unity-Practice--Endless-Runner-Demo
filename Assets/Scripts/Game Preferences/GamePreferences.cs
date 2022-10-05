using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePreferences
{
    public static string IsMusicOn = "IsMusicOn";
    public static string EasyDifficulty = "EasyDifficulty";
    public static string MediumDifficulty = "MediumDifficulty";
    public static string HardDifficulty = "HardDifficulty";

    public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
    public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
    public static string HardDifficultyHighScore = "HardDifficultyHighScore";

    public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
    public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
    public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";


    public static void SetMusicState(int state)
    {
        PlayerPrefs.SetInt(IsMusicOn, state);
    }

    public static int GetMusicState()
    {
        return PlayerPrefs.GetInt(IsMusicOn);
    }

    public static void SetEasyDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(EasyDifficulty, difficulty);
    }

    public static int GetEasyDifficulty()
    {
        return PlayerPrefs.GetInt(EasyDifficulty);
    }

    public static void SetMediumDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(MediumDifficulty, difficulty);
    }

    public static int GetMediumDifficulty()
    {
        return PlayerPrefs.GetInt(MediumDifficulty);
    }

    public static void SetHardDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(HardDifficulty, difficulty);
    }

    public static int GetHardDifficulty()
    {
        return PlayerPrefs.GetInt(HardDifficulty);
    }

    public static void SetEasyDifficultyHighScore(int score)
    {
        PlayerPrefs.SetInt(EasyDifficultyHighScore, score);
    }

    public static int GetEasyDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(EasyDifficultyHighScore);
    }

    public static void SetMediumDifficultyHighScore(int score)
    {
        PlayerPrefs.SetInt(MediumDifficultyHighScore, score);
    }

    public static int GetMediumDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(MediumDifficultyHighScore);
    }

    public static void SetHardDifficultyHighScore(int score)
    {
        PlayerPrefs.SetInt(HardDifficultyHighScore, score);
    }

    public static int GetHardDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(HardDifficultyHighScore);
    }

    public static void SetEasyDifficultyCoinScore(int score)
    {
        PlayerPrefs.SetInt(EasyDifficultyCoinScore, score);
    }

    public static int GetEasyDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(EasyDifficultyCoinScore);
    }

    public static void SetMediumDifficultyCoinScore(int score)
    {
        PlayerPrefs.SetInt(MediumDifficultyCoinScore, score);
    }

    public static int GetMediumDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(MediumDifficultyCoinScore);
    }

    public static void SetHardDifficultyCoinScore(int score)
    {
        PlayerPrefs.SetInt(HardDifficultyCoinScore, score);
    }

    public static int GetHardDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(HardDifficultyCoinScore);
    }

}
