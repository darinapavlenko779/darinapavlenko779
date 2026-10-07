using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x0530c198 : MonoBehaviour
{
    private void _0x8861fa5a()
    {
        this.IsGameEnd = true;
        _0x940c8b68.IsAfterLevelComplete = true;
    }

    private void Awake()
    {
        _0x30f65779 = this.gameObject.GetComponent<_0x0530c198>();
    }

    public List<Button> PauseButtons = new();
    public List<TMP_Text> SubtitleText = new();
    public List<TMP_Text> LevelNumberText = new();
    private IEnumerator _0x1e563f28()
    {
        this._0x7da3d9e6();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x940c8b68.Instance._0x442a294c == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x940c8b68.Instance._0x2de945c8)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x7da3d9e6();
            }
        }

        if (!this.IsGameEnd)
            this._0x61da01cb();
    }

    public List<TMP_Text> ScoreText = new();
    private void _0x7da3d9e6()
    {
        this.TimerText.ForEach(_0x14de0016 => _0x14de0016.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x1b90bf95._0x201699a9(new byte[6] { 192, 192, 241, 151, 222, 222 }, 173)));
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x6b34194d;
        this.CurrentGameIndex = _0x940c8b68.Instance._0x442a294c;
        foreach (Button _0x86a9aff6 in this.HomeButtons)
            _0x86a9aff6.onClick.AddListener(() =>
            {
                this._0x012fa42f();
            });
        foreach (Button _0x34c70441 in this.PauseButtons)
            _0x34c70441.onClick.AddListener(() =>
            {
                _0x940c8b68.Instance._0x775f3f6a(false);
                _0x7b505880.Instance._0xc011989b(_0x3beca35c._0x9a99118c.PAUSE);
            });
        this._0x4bf7ebf6();
        this.LevelNumberText.ForEach(_0x14de0016 => _0x14de0016.text = $"LVL {_0x940c8b68._0xcdcbab5f._0x4a7df9ac + 1}");
        if (_0xc303eb22.Instance.IsTimerEnabled)
        {
            this._0x7da3d9e6();
            this.StartCoroutine(this._0x1e563f28());
        }
    }

    private void _0x29dc6cb9()
    {
        if (this.ScoreCurrent >= this._0x11923318)
            this._0x91b5dc14();
        else
            this._0x61da01cb();
    }

    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x91b5dc14()
    {
        if (!this.IsGameEnd)
        {
            this._0x8861fa5a();
            _0x940c8b68.IsAfterLevelComplete = true;
            _0x940c8b68.IsAfterLevelFailed = false;
            _0xea6e75c9 _0x5c75658b = _0x7b505880.Instance._0xa3b3a463(_0x3beca35c._0x9a99118c.WIN).GetComponent<_0xea6e75c9>();
            if (_0xc303eb22.Instance.IsCheckScoreEnabled)
                _0x5c75658b.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x11923318}";
            else
                _0x5c75658b.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xc303eb22.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x3beca35c._0x8454d6c6._0xa94e5651)
                    _0x3beca35c._0x8454d6c6._0xa94e5651 = this.ScoreCurrent;
                _0x5c75658b.ContentAdditionalText.text = $"{_0x3beca35c._0x8454d6c6._0xa94e5651}";
            }
            else
            {
                _0x5c75658b.ContentAdditionalText.text = $"{this._0x51a7fe11}";
                _0x3beca35c._0x8454d6c6._0xa94e5651 += this._0x51a7fe11;
            }

            if (_0xc303eb22.Instance.IsLevelIncrementOnWin)
                ++_0x940c8b68._0xcdcbab5f._0x4a7df9ac;
            _0x7b505880.Instance._0xc011989b(_0x3beca35c._0x9a99118c.WIN);
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
    private static _0x0530c198 _0x30f65779;
    public List<TMP_Text> TimerText = new();
    public int CustomTimeInitial = 30;
    private int _0x11923318 => this.CustomTargetScore + _0x940c8b68._0xcdcbab5f._0x4a7df9ac * 10;

    public int CustomTargetScore = 10;
    private void _0x4bf7ebf6()
    {
        if (_0xc303eb22.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x14de0016 => _0x14de0016.text = $"{this.ScoreCurrent}/{this._0x11923318}");
        else
            this.ScoreText.ForEach(_0x14de0016 => _0x14de0016.text = $"{this.ScoreCurrent}");
    }

    public void _0xac92e612(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x4bf7ebf6();
            this._0xcdab4bc2();
        }
    }

    private void _0xcdab4bc2()
    {
        if (this.ScoreCurrent > _0x940c8b68._0xcdcbab5f._0xeb42772b)
            _0x940c8b68._0xcdcbab5f._0xeb42772b = this.ScoreCurrent;
        if (_0xc303eb22.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x11923318)
                this._0x91b5dc14();
    }

    public void _0x61da01cb()
    {
        if (_0xc303eb22.Instance.IsOnlyWinGameEndEnabled)
            this._0x91b5dc14();
        if (!this.IsGameEnd)
        {
            this._0x8861fa5a();
            _0x940c8b68.IsAfterLevelComplete = false;
            _0x940c8b68.IsAfterLevelFailed = true;
            _0xea6e75c9 _0x9a59bdc8 = _0x7b505880.Instance._0xa3b3a463(_0x3beca35c._0x9a99118c.LOSE).GetComponent<_0xea6e75c9>();
            if (_0xc303eb22.Instance.IsCheckScoreEnabled)
                _0x9a59bdc8.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x11923318}";
            else
                _0x9a59bdc8.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x9a59bdc8.ContentAdditionalText.text = $"{0}";
            _0x3beca35c._0x8454d6c6._0xa94e5651 += 0;
            _0x7b505880.Instance._0xc011989b(_0x3beca35c._0x9a99118c.LOSE);
        }
    }

    public void _0x012fa42f()
    {
        _0x940c8b68.Instance._0x775f3f6a(true);
        _0x940c8b68.Instance.LoadSceneByIndex(_0x3beca35c._0xc6939daa.SCENE_0);
    }

    [HideInInspector]
    public int TimeLeft;
    [HideInInspector]
    public int ScoreCurrent;
    private int _0x6b34194d => this.CustomTimeInitial + _0x940c8b68._0xcdcbab5f._0x4a7df9ac * 10;
    private int _0x51a7fe11 => this.ScoreCurrent;

    public List<Button> HomeButtons = new();
}

internal static class _0x1b90bf95
{
    internal static string _0x201699a9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}