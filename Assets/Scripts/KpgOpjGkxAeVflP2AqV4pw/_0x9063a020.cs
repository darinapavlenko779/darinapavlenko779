using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>
/// Wrapping and outline discipline for every label this game creates at runtime.
///
/// The scene font material carries the themed outline, but a label built with
/// AddComponent gets a fresh instance of that material, so the keyword has to be
/// switched on per label (C.10). Stage 5c3 reads scenes and prefabs only and can
/// never see these, so nothing else will do it.
/// </summary>
public static class _0x9063a020
{
    private static readonly int _0x71a20359 = Shader.PropertyToID(_0x6fff5f04._0xe3fe7abd(new byte[13] { 14, 30, 36, 37, 61, 56, 63, 52, 18, 62, 61, 62, 35 }, 81));
    private static readonly string OutlineKeyword = _0x6fff5f04._0xe3fe7abd(new byte[10] { 214, 204, 205, 213, 208, 215, 220, 198, 214, 215 }, 153);
    /// <summary>
    /// Turns the SDF outline on for one label. A TMP_Text that has not run Awake yet
    /// (built into a sleeping hierarchy) has no font asset, and reading fontMaterial
    /// then throws and unwinds the whole caller - so bail out instead.
    /// </summary>
    public static void ApplyOutline(TMP_Text _0x312ed1ba)
    {
        if (_0x312ed1ba == null || _0x312ed1ba.font == null)
            return;
        Material _0x8f9b96f2 = _0x312ed1ba.fontMaterial;
        if (_0x8f9b96f2 == null)
            return;
        _0x8f9b96f2.EnableKeyword(OutlineKeyword);
        _0x8f9b96f2.SetColor(_0x71a20359, _0xc95d1bd8.Ink);
        _0x8f9b96f2.SetFloat(_0x30eeea12, 0.25f);
        _0x8f9b96f2.SetFloat(_0x77a1b31d, 0.20f);
    }

    /// <summary>Fades a label without the DOTween TMP module, which this project does not ship.</summary>
    public static void FadeTo(TMP_Text _0xaab99850, float _0x13501457, float _0x80ec8ee7, float _0xb64e27eb)
    {
        if (_0xaab99850 == null)
            return;
        TMP_Text _0xe075fc55 = _0xaab99850;
        DOTween.Kill(_0xe075fc55);
        DOTween.To(() => _0xe075fc55.alpha, (float _0xde775227) => _0xe075fc55.alpha = _0xde775227, _0x13501457, _0x80ec8ee7).SetDelay(_0xb64e27eb).SetId(_0xe075fc55);
    }

    /// <summary>
    /// Word wrap OFF, autosize ON with a real floor, outline on. Line breaks are the
    /// caller's job: pass an explicit \n, never let the engine choose the break.
    /// </summary>
    public static void Dress(TMP_Text _0xdab73012, float _0xfc63229c, Color _0x738751c5)
    {
        if (_0xdab73012 == null)
            return;
        _0xdab73012.color = _0x738751c5;
        _0xdab73012.textWrappingMode = TextWrappingModes.NoWrap;
        _0xdab73012.overflowMode = TextOverflowModes.Overflow;
        _0xdab73012.enableAutoSizing = true;
        _0xdab73012.fontSizeMin = _0xc95d1bd8.MinFontSize;
        _0xdab73012.fontSizeMax = Mathf.Max(_0xc95d1bd8.MinFontSize, _0xfc63229c);
        _0xdab73012.fontSize = Mathf.Max(_0xc95d1bd8.MinFontSize, _0xfc63229c);
        _0xdab73012.alignment = TextAlignmentOptions.Center;
        _0xdab73012.raycastTarget = false;
        ApplyOutline(_0xdab73012);
    }

    private static readonly int _0x30eeea12 = Shader.PropertyToID(_0x6fff5f04._0xe3fe7abd(new byte[13] { 255, 239, 213, 212, 204, 201, 206, 197, 247, 201, 196, 212, 200 }, 160));
    private static readonly int _0x77a1b31d = Shader.PropertyToID(_0x6fff5f04._0xe3fe7abd(new byte[11] { 24, 1, 38, 36, 34, 3, 46, 43, 38, 51, 34 }, 71));
}

internal static class _0x6fff5f04
{
    internal static string _0xe3fe7abd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}