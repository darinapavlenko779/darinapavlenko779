using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x3beca35c
{
    public static class _0x9a99118c
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x8454d6c6
    {
        public static int _0xa94e5651
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xe25b914f._0x97559e63(new byte[5] { 185, 149, 147, 148, 137 }, 250)))
                    PlayerPrefs.SetInt(_0xe25b914f._0x97559e63(new byte[5] { 191, 147, 149, 146, 143 }, 252), 0);
                return PlayerPrefs.GetInt(_0xe25b914f._0x97559e63(new byte[5] { 81, 125, 123, 124, 97 }, 18));
            }

            set
            {
                PlayerPrefs.SetInt(_0xe25b914f._0x97559e63(new byte[5] { 247, 219, 221, 218, 199 }, 180), value);
                _0x940c8b68.Instance._0x4ea1cc1f();
            }
        }
    }

    public static class _0x7817e4f1
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xc6939daa
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public class _0x3f9a0ef4
    {
        private static readonly _0x3f9a0ef4 _0x2ec0a6b6 = new();
        public static readonly _0x3f9a0ef4[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x2ec0a6b6,
            _0x2ec0a6b6,
            _0x2ec0a6b6,
        };
        private int _0x330dbc1f => 0;
        private int _0x5f885863 => 10;
        private string _0x3e879192 => _0xe25b914f._0x97559e63(new byte[4] { 194, 234, 225, 250 }, 143);
        private string _0x82ecc84e => _0xe25b914f._0x97559e63(new byte[8] { 122, 115, 96, 115, 122, 77, 6, 75 }, 54);

        private int _0x04069044
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xe25b914f._0x97559e63(new byte[25] { 193, 247, 240, 240, 231, 236, 246, 197, 238, 237, 224, 227, 238, 193, 234, 227, 242, 246, 231, 240, 203, 236, 230, 231, 250 }, 130)))
                    PlayerPrefs.SetInt(_0xe25b914f._0x97559e63(new byte[25] { 247, 193, 198, 198, 209, 218, 192, 243, 216, 219, 214, 213, 216, 247, 220, 213, 196, 192, 209, 198, 253, 218, 208, 209, 204 }, 180), 0);
                return PlayerPrefs.GetInt(_0xe25b914f._0x97559e63(new byte[25] { 104, 94, 89, 89, 78, 69, 95, 108, 71, 68, 73, 74, 71, 104, 67, 74, 91, 95, 78, 89, 98, 69, 79, 78, 83 }, 43));
            }

            set => PlayerPrefs.SetInt(_0xe25b914f._0x97559e63(new byte[25] { 0, 54, 49, 49, 38, 45, 55, 4, 47, 44, 33, 34, 47, 0, 43, 34, 51, 55, 38, 49, 10, 45, 39, 38, 59 }, 67), value);
        }

        public int _0x4a7df9ac
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x3e879192}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x3e879192}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x3e879192}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x3e879192}CurrentLevelIndex", value);
        }

        public int _0xeb42772b
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x3e879192}BestScore"))
                    this._0xeb42772b = 0;
                return PlayerPrefs.GetInt($"{this._0x3e879192}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x3e879192}BestScore", value);
        }

        public bool _0x48029de6
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x3e879192}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x3e879192}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x3e879192}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x3e879192}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }
}

internal static class _0xe25b914f
{
    internal static string _0x97559e63(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}