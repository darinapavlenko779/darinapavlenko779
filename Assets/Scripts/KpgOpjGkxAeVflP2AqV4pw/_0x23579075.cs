using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The sector map: twelve node badges wired into a schematic, each showing how many
/// stars it gave up. Tapping an open node selects it AND starts it, so the sheet
/// never closes back onto the menu it came from - every step of a capture run
/// changes the screen (F.0b).
///
/// The badges are children of the SHEET, not of the card, so each one's anchor is
/// already a screen fraction and the capture scenario needs no nested arithmetic.
/// </summary>
public sealed class _0x23579075 : MonoBehaviour
{
    private void _0x48695bbb(int _0xaae8d91d, Action<int> _0x814f5124)
    {
        float _0xc90daf3b = _0x04ab38d2[_0xaae8d91d % _0x04ab38d2.Length];
        float _0x68271049 = _0x0eff0a30[_0xaae8d91d / _0x04ab38d2.Length];
        RectTransform _0xff1498b7 = _0x6b65542d.Node(this._0x808dd99b, _0x853bd612._0x9ddd289a(new byte[7] { 22, 58, 43, 21, 52, 63, 62 }, 91) + _0xaae8d91d.ToString(), new Vector2(_0xc90daf3b, _0x68271049), new Vector2(186f, 186f));
        Image _0x4904f3ec = _0x6b65542d.Picture(_0xff1498b7, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Night, 0.9f), this._badgeSprite, false, 1f);
        _0x4904f3ec.raycastTarget = true;
        this._0xfc1aed52.Add(_0x4904f3ec);
        RectTransform _0x0c6556a5 = _0x6b65542d.Node(_0xff1498b7, _0x853bd612._0x9ddd289a(new byte[7] { 247, 219, 202, 246, 213, 217, 209 }, 186) + _0xaae8d91d.ToString(), new Vector2(0.5f, 0.5f), new Vector2(96f, 96f));
        Image _0x1bc01361 = _0x6b65542d.Picture(_0x0c6556a5, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.85f), this._lockSprite, false, 1f);
        this._0xe9f5c085.Add(_0x1bc01361);
        _0x6b65542d.Caption(_0xff1498b7, _0x853bd612._0x9ddd289a(new byte[9] { 143, 163, 178, 140, 183, 175, 160, 167, 176 }, 194) + _0xaae8d91d.ToString(), new Vector2(0.5f, 0.62f), new Vector2(150f, 78f), (_0xaae8d91d + 1).ToString(_0x853bd612._0x9ddd289a(new byte[2] { 11, 11 }, 59)), 56f, _0xc95d1bd8.Cream, this._font);
        Image[] _0x749fa74e = new Image[3];
        for (int _0x734b885c = 0; _0x734b885c < 3; _0x734b885c++)
        {
            RectTransform _0x4f1f38d2 = _0x6b65542d.Node(_0xff1498b7, _0x853bd612._0x9ddd289a(new byte[7] { 189, 145, 128, 163, 132, 145, 130 }, 240) + _0xaae8d91d.ToString() + _0x734b885c.ToString(), new Vector2(0.5f + (_0x734b885c - 1) * 0.2f, 0.26f), new Vector2(34f, 34f));
            _0x749fa74e[_0x734b885c] = _0x6b65542d.Picture(_0x4f1f38d2, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.25f), this._starSprite, false, 1f);
        }

        this._0x96a5db8e.Add(_0x749fa74e);
        int _0xf6c765fa = _0xaae8d91d;
        Button _0xc87547c2 = _0xff1498b7.gameObject.AddComponent<Button>();
        _0xc87547c2.targetGraphic = _0x4904f3ec;
        _0xc87547c2.transition = Selectable.Transition.ColorTint;
        ColorBlock _0x127bc862 = _0xc87547c2.colors;
        _0x127bc862.normalColor = Color.white;
        _0x127bc862.highlightedColor = Color.white;
        _0x127bc862.pressedColor = new Color(0.7f, 0.74f, 0.8f, 1f);
        _0x127bc862.disabledColor = new Color(0.45f, 0.45f, 0.55f, 0.55f);
        _0x127bc862.fadeDuration = 0.08f;
        _0xc87547c2.colors = _0x127bc862;
        Transform _0xf95cc078 = _0xff1498b7;
        _0xc87547c2.onClick.AddListener(() => _0x6b65542d.Punch(_0xf95cc078));
        _0xc87547c2.onClick.AddListener(() => _0x814f5124.Invoke(_0xf6c765fa));
        this._0x6d552247.Add(_0xc87547c2);
    }

    [SerializeField]
    private Sprite _plateSprite;
    private RectTransform _0x808dd99b;
    private void _0x29f73854()
    {
        for (int _0xb3c39af2 = 0; _0xb3c39af2 < _0x0eff0a30.Length; _0xb3c39af2++)
        {
            for (int _0xf56d4cbd = 0; _0xf56d4cbd < _0x04ab38d2.Length - 1; _0xf56d4cbd++)
            {
                float _0x3d656c9e = (_0x04ab38d2[_0xf56d4cbd] + _0x04ab38d2[_0xf56d4cbd + 1]) * 0.5f;
                RectTransform _0x7afe0d45 = _0x6b65542d.Node(this._0x808dd99b, _0x853bd612._0x9ddd289a(new byte[8] { 102, 74, 91, 103, 66, 69, 64, 99 }, 43) + _0xb3c39af2.ToString() + _0xf56d4cbd.ToString(), new Vector2(_0x3d656c9e, _0x0eff0a30[_0xb3c39af2]), new Vector2(80f, 8f));
                _0x6b65542d.Picture(_0x7afe0d45, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.75f), null, false, 1f);
            }

            if (_0xb3c39af2 >= _0x0eff0a30.Length - 1)
                continue;
            float _0xb57c6d0f = (_0xb3c39af2 % 2 == 0) ? _0x04ab38d2[_0x04ab38d2.Length - 1] : _0x04ab38d2[0];
            float _0xb1015c7f = (_0x0eff0a30[_0xb3c39af2] + _0x0eff0a30[_0xb3c39af2 + 1]) * 0.5f;
            RectTransform _0x7bdfb989 = _0x6b65542d.Node(this._0x808dd99b, _0x853bd612._0x9ddd289a(new byte[8] { 150, 186, 171, 151, 178, 181, 176, 141 }, 219) + _0xb3c39af2.ToString(), new Vector2(_0xb57c6d0f, _0xb1015c7f), new Vector2(8f, 90f));
            _0x6b65542d.Picture(_0x7bdfb989, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.75f), null, false, 1f);
        }
    }

    private readonly List<Image> _0xe9f5c085 = new List<Image>(_0xabb6ba5f.LevelCount);
    private TextMeshProUGUI _0x81b673ed;
    public void _0x9cce47f0(_0x194db6fe _0x36566f4b)
    {
        if (this._0x808dd99b == null)
            return;
        this._0xf0ad461c(_0x36566f4b);
        this._0x808dd99b.gameObject.SetActive(true);
        this._0x808dd99b.localScale = Vector3.one * 0.94f;
        this._0x808dd99b.DOScale(1f, 0.24f).SetEase(Ease.OutCubic);
    }

    public void _0x94dd636b()
    {
        if (this._0x808dd99b != null)
            this._0x808dd99b.gameObject.SetActive(false);
    }

    public void _0xf0ad461c(_0x194db6fe _0xd48aba26)
    {
        if (_0xd48aba26 == null)
            return;
        for (int _0xe88bae00 = 0; _0xe88bae00 < this._0xfc1aed52.Count; _0xe88bae00++)
        {
            bool _0xa4269e75 = _0xd48aba26._0xf588657e(_0xe88bae00);
            bool _0xa8fe7874 = _0xd48aba26._0xdca3a089(_0xe88bae00);
            int _0xb571a51f = _0xd48aba26._0xacafa94d(_0xe88bae00);
            Image _0x089d268c = this._0xfc1aed52[_0xe88bae00];
            if (_0x089d268c != null)
                _0x089d268c.color = _0xa8fe7874 ? _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Beam, 0.3f) : (_0xa4269e75 ? _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.55f) : _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Night, 0.85f));
            Image _0xa4dad4ca = this._0xe9f5c085[_0xe88bae00];
            if (_0xa4dad4ca != null)
                _0xa4dad4ca.gameObject.SetActive(!_0xa4269e75);
            Image[] _0x6e9c5f9d = this._0x96a5db8e[_0xe88bae00];
            for (int _0xadadf80d = 0; _0xadadf80d < _0x6e9c5f9d.Length; _0xadadf80d++)
                if (_0x6e9c5f9d[_0xadadf80d] != null)
                    _0x6e9c5f9d[_0xadadf80d].color = _0xadadf80d < _0xb571a51f ? _0xc95d1bd8.Gold : _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.22f);
            Button _0xcc0bd3ed = this._0x6d552247[_0xe88bae00];
            if (_0xcc0bd3ed != null)
                _0xcc0bd3ed.interactable = _0xa4269e75;
        }
    }

    private static readonly float[] _0x0eff0a30 =
    {
        0.625f,
        0.527f,
        0.429f,
        0.331f
    };
    [SerializeField]
    private Sprite _lockSprite;
    [SerializeField]
    private TMP_FontAsset _font;
    private readonly List<Image[]> _0x96a5db8e = new List<Image[]>(_0xabb6ba5f.LevelCount);
    private readonly List<Image> _0xfc1aed52 = new List<Image>(_0xabb6ba5f.LevelCount);
    private readonly List<Button> _0x6d552247 = new List<Button>(_0xabb6ba5f.LevelCount);
    [SerializeField]
    private Sprite _closeIcon;
    public void _0x7eaddc72(Transform _0x3363dea8, _0x194db6fe _0x0a577172, Action<int> _0xf19fbbb7)
    {
        this._0x808dd99b = _0x6b65542d.Sheet(_0x3363dea8, _0x853bd612._0x9ddd289a(new byte[12] { 207, 238, 229, 228, 204, 224, 241, 210, 233, 228, 228, 245 }, 129));
        _0x6b65542d.Shade(this._0x808dd99b, _0x853bd612._0x9ddd289a(new byte[12] { 56, 25, 18, 19, 59, 23, 6, 37, 30, 23, 18, 19 }, 118), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.NightDeep, 0.92f), () => this._0x94dd636b());
        RectTransform _0xe04be58c = _0x6b65542d.Node(this._0x808dd99b, _0x853bd612._0x9ddd289a(new byte[11] { 168, 137, 130, 131, 171, 135, 150, 165, 135, 148, 130 }, 230), new Vector2(0.5f, 0.5f), new Vector2(1040f, 1500f));
        Image _0x5d27e6bd = _0x6b65542d.Picture(_0xe04be58c, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Surface, 0.95f), this._plateSprite, this._plateSprite != null, 4.4f);
        _0x5d27e6bd.raycastTarget = true;
        RectTransform _0x3609597f = _0x6b65542d.Sheet(_0xe04be58c, _0x853bd612._0x9ddd289a(new byte[10] { 253, 220, 215, 214, 254, 210, 195, 225, 218, 222 }, 179));
        _0x6b65542d.Picture(_0x3609597f, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f), this._plateSprite, this._plateSprite != null, 6.2f);
        _0x6b65542d.Caption(this._0x808dd99b, _0x853bd612._0x9ddd289a(new byte[12] { 39, 6, 13, 12, 36, 8, 25, 61, 0, 29, 5, 12 }, 105), new Vector2(0.5f, 0.745f), new Vector2(760f, 100f), _0x853bd612._0x9ddd289a(new byte[8] { 30, 8, 14, 25, 2, 31, 109, 4 }, 77), 64f, _0xc95d1bd8.Beam, this._font);
        _0x6b65542d.Caption(this._0x808dd99b, _0x853bd612._0x9ddd289a(new byte[11] { 216, 249, 242, 243, 219, 247, 230, 218, 243, 247, 242 }, 150), new Vector2(0.5f, 0.705f), new Vector2(820f, 64f), _0x853bd612._0x9ddd289a(new byte[13] { 193, 215, 222, 215, 209, 198, 178, 211, 178, 220, 221, 214, 215 }, 146), 38f, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.75f), this._font);
        _0x6b65542d.IconButton(this._0x808dd99b, _0x853bd612._0x9ddd289a(new byte[12] { 64, 97, 106, 107, 67, 111, 126, 77, 98, 97, 125, 107 }, 14), new Vector2(0.845f, 0.748f), new Vector2(100f, 100f), this._closeIcon, _0xc95d1bd8.Cream, () => this._0x94dd636b());
        // the schematic is laid first, so every badge is a later sibling and sits on top
        this._0x29f73854();
        // an empty board can only happen if the catalogue is ever emptied, and a blank
        // sheet would tell the player nothing (rule G, empty states)
        this._0x81b673ed = _0x6b65542d.Caption(this._0x808dd99b, _0x853bd612._0x9ddd289a(new byte[12] { 26, 59, 48, 49, 25, 53, 36, 17, 57, 36, 32, 45 }, 84), new Vector2(0.5f, 0.5f), new Vector2(820f, 120f), _0x853bd612._0x9ddd289a(new byte[20] { 127, 126, 17, 127, 126, 117, 116, 98, 17, 114, 121, 112, 99, 101, 116, 117, 17, 104, 116, 101 }, 49), 44f, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.8f), this._font);
        this._0x81b673ed.gameObject.SetActive(_0xabb6ba5f.LevelCount <= 0);
        for (int _0xf196c112 = 0; _0xf196c112 < _0xabb6ba5f.LevelCount; _0xf196c112++)
            this._0x48695bbb(_0xf196c112, _0xf19fbbb7);
        this._0xf0ad461c(_0x0a577172);
        this._0x808dd99b.gameObject.SetActive(false);
    }

    [SerializeField]
    private Sprite _badgeSprite;
    [SerializeField]
    private Sprite _starSprite;
    private static readonly float[] _0x04ab38d2 =
    {
        0.285f,
        0.5f,
        0.715f
    };
}

internal static class _0x853bd612
{
    internal static string _0x9ddd289a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}