using UnityEngine;

/// <summary>
/// What the player has unlocked, kept in PlayerPrefs under fixed literal keys.
///
/// The keys are deliberately spelled out rather than derived from member names: a
/// name-derived key would be rewritten by the obfuscator and every saved game would
/// read back empty after the first release.
/// </summary>
public sealed class _0x194db6fe
{
    /// <summary>A node opens when the one before it has been cleared; the first is always open.</summary>
    public bool _0xf588657e(int _0xdb0f2bea)
    {
        return _0xdb0f2bea <= 0 || this._0xdca3a089(_0xdb0f2bea - 1);
    }

    public int _0x9bc90056
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(CurrentKey, 0), 0, _0xabb6ba5f.LevelCount - 1);
        }

        set
        {
            PlayerPrefs.SetInt(CurrentKey, Mathf.Clamp(value, 0, _0xabb6ba5f.LevelCount - 1));
        }
    }

    private static readonly string StarsKey = _0x1057b30b._0xaef4e9f1(new byte[14] { 163, 177, 253, 189, 188, 183, 182, 253, 160, 167, 178, 161, 160, 253 }, 211);
    /// <summary>Records a clear and pays the shards; a replay only ever improves the rating.</summary>
    public int _0xe048fe34(int _0x306e3410, int _0xd1ac8235)
    {
        int _0x3ab988f7 = this._0xacafa94d(_0x306e3410);
        int _0xd2f035df = Mathf.Max(_0x3ab988f7, _0xd1ac8235);
        PlayerPrefs.SetInt(StarsKey + _0x306e3410.ToString(), _0xd2f035df);
        int _0x5ab2696d = Mathf.Max(0, _0xd2f035df - _0x3ab988f7);
        if (_0x5ab2696d > 0)
            _0x3beca35c._0x8454d6c6._0xa94e5651 = _0x3beca35c._0x8454d6c6._0xa94e5651 + _0x5ab2696d;
        PlayerPrefs.Save();
        return _0x5ab2696d;
    }

    public int _0x029855c3()
    {
        int _0xeb6da8ef = 0;
        for (int _0x49b313d2 = 0; _0x49b313d2 < _0xabb6ba5f.LevelCount; _0x49b313d2++)
            if (this._0xdca3a089(_0x49b313d2))
                _0xeb6da8ef++;
        return _0xeb6da8ef;
    }

    /// <summary>Three for par, two for one tap over, one for finishing at all.</summary>
    public static int StarsEarned(int _0x2fd33075, int _0x79ffb365)
    {
        if (_0x2fd33075 <= _0x79ffb365)
            return 3;
        return _0x2fd33075 <= _0x79ffb365 + 1 ? 2 : 1;
    }

    public int _0xd6f9a310(int _0x27f37d44)
    {
        return PlayerPrefs.GetInt(AttemptKey + _0x27f37d44.ToString(), 0);
    }

    public void _0x2f4592ef(int _0x8a52a436)
    {
        PlayerPrefs.SetInt(AttemptKey + _0x8a52a436.ToString(), this._0xd6f9a310(_0x8a52a436) + 1);
    }

    public int _0x7bf24d85
    {
        get
        {
            return _0x3beca35c._0x8454d6c6._0xa94e5651;
        }
    }

    private static readonly string CurrentKey = _0x1057b30b._0xaef4e9f1(new byte[15] { 67, 81, 29, 93, 92, 87, 86, 29, 80, 70, 65, 65, 86, 93, 71 }, 51);
    public int _0xacafa94d(int _0xe7f1f02b)
    {
        return Mathf.Clamp(PlayerPrefs.GetInt(StarsKey + _0xe7f1f02b.ToString(), 0), 0, 3);
    }

    public bool _0xdca3a089(int _0x2586b7e0)
    {
        return this._0xacafa94d(_0x2586b7e0) > 0;
    }

    private static readonly string AttemptKey = _0x1057b30b._0xaef4e9f1(new byte[12] { 135, 149, 217, 153, 152, 147, 146, 217, 131, 133, 142, 217 }, 247);
}

internal static class _0x1057b30b
{
    internal static string _0xaef4e9f1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}