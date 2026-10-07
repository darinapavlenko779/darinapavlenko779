using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xf25d92e4 : MonoBehaviour
{
    private static float Ratio(Color _0x69445d17, Color _0x64c005f5)
    {
        float _0xe5a04a18 = Luminance(_0x69445d17);
        float _0x28a6b37f = Luminance(_0x64c005f5);
        return (Mathf.Max(_0xe5a04a18, _0x28a6b37f) + 0.05f) / (Mathf.Min(_0xe5a04a18, _0x28a6b37f) + 0.05f);
    }

    private readonly HashSet<TMP_Text> _0x1e5b24ef = new HashSet<TMP_Text>();
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x078290ab(Object _0x49d62984)
    {
        TMP_Text _0xf6f47306 = _0x49d62984 as TMP_Text;
        if (_0xf6f47306 != null)
            this._0x1e5b24ef.Add(_0xf6f47306);
    }

    private static float Linear(float _0x043ae2be)
    {
        _0x043ae2be = Mathf.Clamp01(_0x043ae2be);
        return _0x043ae2be <= 0.03928f ? _0x043ae2be / 12.92f : Mathf.Pow((_0x043ae2be + 0.055f) / 1.055f, 2.4f);
    }

    private readonly List<TMP_Text> _0x7e72547d = new List<TMP_Text>();
    private void LateUpdate()
    {
        if (this._0x1e5b24ef.Count == 0)
            return;
        this._0x7e72547d.Clear();
        this._0x7e72547d.AddRange(this._0x1e5b24ef);
        this._0x1e5b24ef.Clear();
        for (int _0x0ca39f84 = 0; _0x0ca39f84 < this._0x7e72547d.Count; _0x0ca39f84++)
            Fix(this._0x7e72547d[_0x0ca39f84]);
    }

    private void OnEnable()
    {
        if (this._0x62c652b1 == null)
            this._0x62c652b1 = _0x362c257c => this._0x078290ab(_0x362c257c);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x62c652b1);
    }

    private static void Fix(TMP_Text _0x537b3541)
    {
        if (_0x537b3541 == null || !_0x537b3541.isActiveAndEnabled)
            return;
        Material _0x2e48b234 = _0x537b3541.fontSharedMaterial;
        if (_0x2e48b234 == null || !_0x2e48b234.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x2e48b234.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x2e48b234.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x88660ed6 = _0x537b3541.color;
        if (_0x88660ed6.a <= 0f)
            return;
        Color _0x1cb600cd = _0x2e48b234.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x88660ed6, _0x1cb600cd) >= MinRatio)
            return;
        Color _0xb3b8b7a4 = Luminance(_0x1cb600cd) < 0.5f ? Color.white : Color.black;
        Color _0xb7b49258;
        if (Ratio(_0xb3b8b7a4, _0x1cb600cd) < TargetRatio)
        {
            _0xb7b49258 = _0xb3b8b7a4;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x2f5a2ce1 = 0f;
            float _0xfb4138bc = 1f;
            for (int _0xaf71043a = 0; _0xaf71043a < 20; _0xaf71043a++)
            {
                float _0x8b52c378 = (_0x2f5a2ce1 + _0xfb4138bc) * 0.5f;
                if (Ratio(Color.Lerp(_0x88660ed6, _0xb3b8b7a4, _0x8b52c378), _0x1cb600cd) >= TargetRatio)
                    _0xfb4138bc = _0x8b52c378;
                else
                    _0x2f5a2ce1 = _0x8b52c378;
            }

            _0xb7b49258 = Color.Lerp(_0x88660ed6, _0xb3b8b7a4, _0xfb4138bc);
        }

        _0xb7b49258.a = _0x88660ed6.a;
        _0x537b3541.color = _0xb7b49258;
    }

    private const float MinOutlineWidth = 0.01f;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x014bf843 != null)
            return;
        GameObject _0x82fd8ffc = new GameObject(_0x727389bc._0x75905bc5(new byte[16] { 25, 32, 61, 14, 34, 35, 57, 63, 44, 62, 57, 10, 56, 44, 63, 41 }, 77));
        _0x82fd8ffc.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x82fd8ffc);
        _0x014bf843 = _0x82fd8ffc.AddComponent<_0xf25d92e4>();
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x62c652b1;
    private const float TargetRatio = 7f;
    private void OnDisable()
    {
        if (this._0x62c652b1 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x62c652b1);
    }

    private const float MinRatio = 4.5f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x0eea4c69)
    {
        return 0.2126f * Linear(_0x0eea4c69.r) + 0.7152f * Linear(_0x0eea4c69.g) + 0.0722f * Linear(_0x0eea4c69.b);
    }

    private static _0xf25d92e4 _0x014bf843;
}

internal static class _0x727389bc
{
    internal static string _0x75905bc5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}