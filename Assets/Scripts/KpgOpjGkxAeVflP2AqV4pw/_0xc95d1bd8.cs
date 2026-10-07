using UnityEngine;

/// <summary>
/// The single source of colour and depth for this game.
///
/// Colours are the ticket palette. The sorting constants are the -19..-1 corridor:
/// the background canvas draws at -30 and the win/lose/pause canvases at +10, so a
/// world sprite outside that band either disappears behind the backdrop or climbs
/// over the result cards (CLAUDE-unity.md C.21).
/// </summary>
public static class _0xc95d1bd8
{
    /// <summary>
    /// Autosize floor. Autosize is judged by its MINIMUM (C.12): a long line shrinks
    /// straight down to this value, so it is the size that really ships.
    /// </summary>
    public const float MinFontSize = 30f;
    public static readonly Color VioletDeep = new Color(0.180f, 0.110f, 0.388f, 1f);
    public const float RefHeight = 2688f;
    // sorting band - allocated once, never written inline at a call site
    public const int GlowPlateOrder = -18;
    public const int SparkOrder = -6;
    public static readonly Color Night = new Color(0.078f, 0.086f, 0.184f, 1f);
    public static readonly Color NightDeep = new Color(0.039f, 0.043f, 0.110f, 1f);
    /// <summary>The outline colour of every label; no text may be this dark (C.14).</summary>
    public static readonly Color Ink = new Color(0.039f, 0.043f, 0.110f, 1f);
    public static readonly Color Cream = new Color(0.957f, 0.949f, 0.925f, 1f);
    public static Color Blend(Color _0xcec51cc4, Color _0xe0789b84, float _0xee7ec748)
    {
        float _0x8fa8f5c7 = Mathf.Clamp01(_0xee7ec748);
        return new Color(_0xcec51cc4.r + (_0xe0789b84.r - _0xcec51cc4.r) * _0x8fa8f5c7, _0xcec51cc4.g + (_0xe0789b84.g - _0xcec51cc4.g) * _0x8fa8f5c7, _0xcec51cc4.b + (_0xe0789b84.b - _0xcec51cc4.b) * _0x8fa8f5c7, _0xcec51cc4.a + (_0xe0789b84.a - _0xcec51cc4.a) * _0x8fa8f5c7);
    }

    public const int GlyphOrder = -11;
    public static readonly Color Rose = new Color(0.937f, 0.365f, 0.510f, 1f);
    public static readonly Color Gold = new Color(0.965f, 0.784f, 0.298f, 1f);
    public const int TileOrder = -14;
    public static readonly Color Surface = new Color(0.106f, 0.114f, 0.235f, 1f);
    public const int LinkOrder = -8;
    public static Color WithAlpha(Color _0xcea09fca, float _0x31e36d7a)
    {
        return new Color(_0xcea09fca.r, _0xcea09fca.g, _0xcea09fca.b, _0x31e36d7a);
    }

    public static readonly Color BeamPale = new Color(0.561f, 0.918f, 0.933f, 1f);
    public const int HintRingOrder = -5;
    public static readonly Color Violet = new Color(0.318f, 0.196f, 0.659f, 1f);
    public const int JointOrder = -7;
    public static readonly Color Beam = new Color(0.184f, 0.784f, 0.812f, 1f);
    // CanvasScaler reference resolution of both scene templates
    public const float RefWidth = 1242f;
}