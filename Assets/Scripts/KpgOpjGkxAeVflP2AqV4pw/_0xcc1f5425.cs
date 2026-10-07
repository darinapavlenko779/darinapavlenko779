using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Owns the three result cards. Each pop is addressed by its SETTINGS index, never
/// by name, and is dressed ENTIRELY here: the template body is emptied and a themed
/// card built in its place, so none of the template's own wording, none of its
/// Score/Reward rows and none of its unassigned close image - which Unity would draw
/// as a plain white slab - can reach a screen (C.3, C.15, C.17).
///
/// A body that ships asleep is woken BEFORE anything is built into it: a TMP label
/// added to a dead hierarchy never runs Awake, and reading its material then throws
/// and unwinds the caller before the pop is ever raised.
/// </summary>
public sealed class _0xcc1f5425 : MonoBehaviour
{
    private Action _0x3642b0ff;
    public void _0x69b0c373(bool _0x41044cc0, int _0xfa679e02, int _0x327da73f, int _0xb0122698, int _0x11fae2f9)
    {
        if (_0x7b505880.Instance == null)
            return;
        if (this._0x58a699fe != null)
            this._0x58a699fe.text = _0x41044cc0 ? _0x92ed33d3._0x56119da3(new byte[15] { 174, 187, 160, 173, 201, 166, 191, 172, 187, 165, 166, 168, 173, 172, 173 }, 233) : _0x92ed33d3._0x56119da3(new byte[12] { 114, 104, 105, 29, 114, 123, 29, 112, 114, 107, 120, 110 }, 61);
        if (this._0xe7a9e7e6 != null)
            this._0xe7a9e7e6.text = _0x41044cc0 ? _0x92ed33d3._0x56119da3(new byte[51] { 29, 124, 30, 16, 19, 31, 23, 25, 14, 124, 24, 14, 29, 18, 23, 124, 8, 20, 25, 124, 16, 21, 27, 20, 8, 86, 29, 18, 24, 124, 30, 9, 14, 18, 25, 24, 124, 8, 20, 25, 124, 16, 29, 15, 8, 124, 17, 19, 10, 25, 15 }, 92) : _0x92ed33d3._0x56119da3(new byte[34] { 182, 170, 167, 194, 160, 167, 163, 175, 194, 172, 167, 180, 167, 176, 194, 176, 167, 163, 161, 170, 167, 166, 232, 182, 170, 167, 194, 161, 176, 187, 177, 182, 163, 174 }, 226);
        if (this._0xa824d6b3 != null)
            this._0xa824d6b3.text = _0x92ed33d3._0x56119da3(new byte[10] { 0, 1, 10, 11, 29, 110, 2, 7, 26, 110 }, 78) + _0xfa679e02.ToString() + _0x92ed33d3._0x56119da3(new byte[3] { 73, 70, 73 }, 105) + _0x327da73f.ToString() + _0x92ed33d3._0x56119da3(new byte[9] { 58, 58, 58, 87, 85, 76, 95, 73, 58 }, 26) + _0xb0122698.ToString(_0x92ed33d3._0x56119da3(new byte[2] { 253, 253 }, 205)) + _0x92ed33d3._0x56119da3(new byte[3] { 107, 100, 107 }, 75) + _0x11fae2f9.ToString(_0x92ed33d3._0x56119da3(new byte[2] { 15, 15 }, 63));
        _0x7b505880.Instance._0xc011989b(_0x3beca35c._0x9a99118c.LOSE);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
    }

    private TextMeshProUGUI _0xa824d6b3;
    // ---------------------------------------------------------------------- raising
    public void _0x6cc853ac(int _0xb41d7d9f, int _0xca7dc348, int _0x85b09c14, int _0xb2efcae8)
    {
        if (_0x7b505880.Instance == null)
            return;
        if (this._0x48a70b03 != null)
            this._0x48a70b03.text = _0x92ed33d3._0x56119da3(new byte[5] { 85, 84, 95, 94, 59 }, 27) + (_0xb41d7d9f + 1).ToString(_0x92ed33d3._0x56119da3(new byte[2] { 192, 192 }, 240)) + _0x92ed33d3._0x56119da3(new byte[8] { 229, 134, 137, 128, 132, 151, 128, 129 }, 197);
        if (this._0xc22cfb2d != null)
            this._0xc22cfb2d.text = _0x92ed33d3._0x56119da3(new byte[11] { 1, 3, 26, 9, 31, 108, 25, 31, 9, 8, 108 }, 76) + _0x85b09c14.ToString(_0x92ed33d3._0x56119da3(new byte[2] { 137, 137 }, 185)) + _0x92ed33d3._0x56119da3(new byte[3] { 131, 140, 131 }, 163) + _0xb2efcae8.ToString(_0x92ed33d3._0x56119da3(new byte[2] { 69, 69 }, 117));
        for (int _0xc61aadb4 = 0; _0xc61aadb4 < this._0xaf2e1784.Count; _0xc61aadb4++)
        {
            Image _0x9d2d14ec = this._0xaf2e1784[_0xc61aadb4];
            if (_0x9d2d14ec == null)
                continue;
            bool _0x2da913e9 = _0xc61aadb4 < _0xca7dc348;
            _0x9d2d14ec.color = _0x2da913e9 ? _0xc95d1bd8.Gold : _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.22f);
            Transform _0xc6edb4ec = _0x9d2d14ec.transform;
            DOTween.Kill(_0xc6edb4ec);
            _0xc6edb4ec.localScale = Vector3.zero;
            _0xc6edb4ec.DOScale(1f, 0.26f).SetDelay(0.12f * _0xc61aadb4).SetEase(Ease.OutBack);
        }

        _0x7b505880.Instance._0xc011989b(_0x3beca35c._0x9a99118c.WIN);
    }

    private TMP_FontAsset _0xbf750ddb;
    private void _0xc6473604(_0xea6e75c9 _0x97568fa4, Action _0x9d11f730, Action _0xb555a858)
    {
        RectTransform _0xa3a13578 = this._0x8e7f94b1(_0x97568fa4, _0xc95d1bd8.Beam);
        if (_0xa3a13578 == null)
            return;
        _0x6b65542d.Caption(_0xa3a13578, _0x92ed33d3._0x56119da3(new byte[9] { 81, 111, 104, 78, 99, 103, 98, 99, 116 }, 6), new Vector2(0.5f, 0.885f), new Vector2(880f, 118f), _0x92ed33d3._0x56119da3(new byte[14] { 171, 186, 177, 187, 188, 169, 164, 200, 167, 166, 164, 161, 166, 173 }, 232), 72f, _0xc95d1bd8.Beam, this._0xbf750ddb);
        for (int _0xaad43f0d = 0; _0xaad43f0d < 3; _0xaad43f0d++)
        {
            RectTransform _0x05288d3d = _0x6b65542d.Node(_0xa3a13578, _0x92ed33d3._0x56119da3(new byte[7] { 109, 83, 84, 105, 78, 91, 72 }, 58) + _0xaad43f0d.ToString(), new Vector2(0.5f + (_0xaad43f0d - 1) * 0.112f, 0.735f), new Vector2(96f, 96f));
            this._0xaf2e1784.Add(_0x6b65542d.Picture(_0x05288d3d, _0xc95d1bd8.Gold, this._0xed9c3d41, false, 1f));
        }

        this._0x48a70b03 = _0x6b65542d.Caption(_0xa3a13578, _0x92ed33d3._0x56119da3(new byte[7] { 233, 215, 208, 252, 209, 218, 199 }, 190), new Vector2(0.5f, 0.585f), new Vector2(880f, 88f), _0x92ed33d3._0x56119da3(new byte[15] { 22, 23, 28, 29, 120, 104, 105, 120, 27, 20, 29, 25, 10, 29, 28 }, 88), 44f, _0xc95d1bd8.Cream, this._0xbf750ddb);
        this._0xc22cfb2d = _0x6b65542d.Caption(_0xa3a13578, _0x92ed33d3._0x56119da3(new byte[8] { 254, 192, 199, 236, 209, 221, 219, 200 }, 169), new Vector2(0.5f, 0.49f), new Vector2(880f, 76f), _0x92ed33d3._0x56119da3(new byte[18] { 113, 115, 106, 121, 111, 28, 105, 111, 121, 120, 28, 12, 12, 28, 19, 28, 12, 12 }, 60), 38f, _0xc95d1bd8.Gold, this._0xbf750ddb);
        _0x6b65542d.ActionButton(_0xa3a13578, _0x92ed33d3._0x56119da3(new byte[7] { 240, 206, 201, 233, 194, 223, 211 }, 167), new Vector2(0.5f, 0.285f), new Vector2(720f, 152f), _0xc95d1bd8.Beam, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.85f), _0xc95d1bd8.Cream, _0x92ed33d3._0x56119da3(new byte[9] { 124, 119, 106, 102, 18, 124, 125, 118, 119 }, 50), 50f, this._0x30068954, 1.9f, this._0xbf750ddb, () => _0x9d11f730.Invoke());
        _0x6b65542d.ActionButton(_0xa3a13578, _0x92ed33d3._0x56119da3(new byte[6] { 77, 115, 116, 87, 123, 106 }, 26), new Vector2(0.5f, 0.125f), new Vector2(560f, 124f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Beam, 0.8f), _0xc95d1bd8.Cream, _0x92ed33d3._0x56119da3(new byte[8] { 2, 3, 8, 9, 108, 1, 13, 28 }, 76), 42f, this._0x30068954, 1.9f, this._0xbf750ddb, () => _0xb555a858.Invoke());
    }

    private void _0x0913005f(_0xea6e75c9 _0x7af2d5d1, Action _0x4b9f0bcf, Action _0x014bf485, Action _0xa9891d99)
    {
        RectTransform _0x2c834238 = this._0x8e7f94b1(_0x7af2d5d1, _0xc95d1bd8.Gold);
        if (_0x2c834238 == null)
            return;
        _0x6b65542d.Caption(_0x2c834238, _0x92ed33d3._0x56119da3(new byte[11] { 60, 13, 25, 31, 9, 36, 9, 13, 8, 9, 30 }, 108), new Vector2(0.5f, 0.885f), new Vector2(880f, 118f), _0x92ed33d3._0x56119da3(new byte[11] { 23, 16, 20, 24, 117, 5, 20, 0, 6, 16, 17 }, 85), 70f, _0xc95d1bd8.Cream, this._0xbf750ddb);
        RectTransform _0x9945df8f = _0x6b65542d.Node(_0x2c834238, _0x92ed33d3._0x56119da3(new byte[10] { 123, 74, 94, 88, 78, 108, 71, 82, 91, 67 }, 43), new Vector2(0.5f, 0.735f), new Vector2(128f, 128f));
        _0x6b65542d.Picture(_0x9945df8f, _0xc95d1bd8.Beam, this._0x6dffb0da, false, 1f);
        this._0x50361ed4 = _0x6b65542d.Caption(_0x2c834238, _0x92ed33d3._0x56119da3(new byte[9] { 106, 91, 79, 73, 95, 120, 85, 94, 67 }, 58), new Vector2(0.5f, 0.61f), new Vector2(880f, 86f), _0x92ed33d3._0x56119da3(new byte[17] { 128, 156, 145, 244, 134, 155, 129, 128, 145, 244, 157, 135, 244, 156, 145, 152, 144 }, 212), 44f, _0xc95d1bd8.Cream, this._0xbf750ddb);
        this._0x6a4ef2b5 = _0x6b65542d.Caption(_0x2c834238, _0x92ed33d3._0x56119da3(new byte[10] { 178, 131, 151, 145, 135, 167, 154, 150, 144, 131 }, 226), new Vector2(0.5f, 0.525f), new Vector2(880f, 76f), _0x92ed33d3._0x56119da3(new byte[13] { 145, 147, 138, 153, 143, 252, 144, 153, 154, 136, 252, 236, 236 }, 220), 38f, _0xc95d1bd8.Gold, this._0xbf750ddb);
        _0x6b65542d.ActionButton(_0x2c834238, _0x92ed33d3._0x56119da3(new byte[11] { 178, 131, 151, 145, 135, 176, 135, 145, 151, 143, 135 }, 226), new Vector2(0.5f, 0.375f), new Vector2(720f, 152f), _0xc95d1bd8.Beam, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.85f), _0xc95d1bd8.Cream, _0x92ed33d3._0x56119da3(new byte[6] { 235, 252, 234, 236, 244, 252 }, 185), 50f, this._0x30068954, 1.9f, this._0xbf750ddb, () => _0x4b9f0bcf.Invoke());
        _0x6b65542d.ActionButton(_0x2c834238, _0x92ed33d3._0x56119da3(new byte[12] { 139, 186, 174, 168, 190, 137, 190, 168, 175, 186, 169, 175 }, 219), new Vector2(0.5f, 0.235f), new Vector2(560f, 124f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Gold, 0.8f), _0xc95d1bd8.Cream, _0x92ed33d3._0x56119da3(new byte[12] { 49, 38, 48, 55, 34, 49, 55, 67, 45, 44, 39, 38 }, 99), 42f, this._0x30068954, 1.9f, this._0xbf750ddb, () => _0x014bf485.Invoke());
        _0x6b65542d.ActionButton(_0x2c834238, _0x92ed33d3._0x56119da3(new byte[8] { 192, 241, 229, 227, 245, 221, 241, 224 }, 144), new Vector2(0.5f, 0.105f), new Vector2(560f, 124f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Beam, 0.8f), _0xc95d1bd8.Cream, _0x92ed33d3._0x56119da3(new byte[8] { 33, 32, 43, 42, 79, 34, 46, 63 }, 111), 42f, this._0x30068954, 1.9f, this._0xbf750ddb, () => _0xa9891d99.Invoke());
    }

    private Sprite _0xed9c3d41;
    private Sprite _0x6dffb0da;
    private Sprite _0x30068954;
    private const float PauseReleaseSeconds = 9f;
    private bool _0xf5b038a8;
    private TextMeshProUGUI _0xc22cfb2d;
    private TextMeshProUGUI _0xe7a9e7e6;
    // ------------------------------------------------------------ card scaffolding
    private RectTransform _0x8e7f94b1(_0xea6e75c9 _0xa059201f, Color _0x815b7abb)
    {
        if (_0xa059201f == null || _0xa059201f.Content == null)
            return null;
        _0xa059201f.Content.SetActive(true);
        _0x6b65542d.ClearChildren(_0xa059201f.Content.transform);
        RectTransform _0x5cbfbf08 = _0x6b65542d.Node(_0xa059201f.Content.transform, _0x92ed33d3._0x56119da3(new byte[10] { 63, 8, 30, 24, 1, 25, 46, 12, 31, 9 }, 109), new Vector2(0.5f, 0.5f), new Vector2(1000f, 1180f));
        Image _0xe61cdd20 = _0x6b65542d.Picture(_0x5cbfbf08, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Surface, 0.96f), this._0x30068954, this._0x30068954 != null, 1.4f);
        _0xe61cdd20.raycastTarget = true;
        RectTransform _0x404e1dbf = _0x6b65542d.Sheet(_0x5cbfbf08, _0x92ed33d3._0x56119da3(new byte[7] { 189, 159, 140, 154, 172, 151, 147 }, 254));
        _0x6b65542d.Picture(_0x404e1dbf, _0xc95d1bd8.WithAlpha(_0x815b7abb, 0.9f), this._0x30068954, this._0x30068954 != null, 2.6f);
        // our own close glyph; the template's close Image has no sprite at all
        _0x6b65542d.IconButton(_0x5cbfbf08, _0x92ed33d3._0x56119da3(new byte[9] { 21, 55, 36, 50, 21, 58, 57, 37, 51 }, 86), new Vector2(0.88f, 0.93f), new Vector2(104f, 104f), this._0xe316d2cf, _0xc95d1bd8.Cream, () => this._0x30f2ef58());
        return _0x5cbfbf08;
    }

    /// <summary>
    /// The pause card lets itself go after a few seconds: a capture run whose RESUME
    /// tap missed would otherwise park the whole session on this card.
    /// </summary>
    public void _0x378a70c2(int _0x23645237)
    {
        if (_0x7b505880.Instance == null)
            return;
        if (this._0x6a4ef2b5 != null)
            this._0x6a4ef2b5.text = _0x92ed33d3._0x56119da3(new byte[11] { 51, 49, 40, 59, 45, 94, 50, 59, 56, 42, 94 }, 126) + Mathf.Max(0, _0x23645237).ToString(_0x92ed33d3._0x56119da3(new byte[2] { 98, 98 }, 82));
        if (this._0x50361ed4 != null)
            this._0x50361ed4.text = _0x92ed33d3._0x56119da3(new byte[17] { 157, 129, 140, 233, 155, 134, 156, 157, 140, 233, 128, 154, 233, 129, 140, 133, 141 }, 201);
        _0x7b505880.Instance._0xc011989b(_0x3beca35c._0x9a99118c.PAUSE);
        DOVirtual.DelayedCall(PauseReleaseSeconds, () => this._0x30f2ef58()).SetId(this);
    }

    public void _0x8b3e5483()
    {
        DOTween.Kill(this);
    }

    private TextMeshProUGUI _0x6a4ef2b5;
    private TextMeshProUGUI _0x50361ed4;
    private Sprite _0x5ca6d9f3;
    private readonly List<Image> _0xaf2e1784 = new List<Image>(3);
    private void _0xed57a54b(_0xea6e75c9 _0xc75fd2ad, Action _0x121f3876, Action _0xf1ddf6a5)
    {
        RectTransform _0x96df998f = this._0x8e7f94b1(_0xc75fd2ad, _0xc95d1bd8.Rose);
        if (_0x96df998f == null)
            return;
        this._0x58a699fe = _0x6b65542d.Caption(_0x96df998f, _0x92ed33d3._0x56119da3(new byte[10] { 61, 30, 2, 20, 57, 20, 16, 21, 20, 3 }, 113), new Vector2(0.5f, 0.88f), new Vector2(880f, 118f), _0x92ed33d3._0x56119da3(new byte[12] { 93, 71, 70, 50, 93, 84, 50, 95, 93, 68, 87, 65 }, 18), 68f, _0xc95d1bd8.Rose, this._0xbf750ddb);
        RectTransform _0xfe253aa7 = _0x6b65542d.Node(_0x96df998f, _0x92ed33d3._0x56119da3(new byte[8] { 154, 185, 165, 179, 155, 183, 164, 189 }, 214), new Vector2(0.5f, 0.69f), new Vector2(230f, 230f));
        Image _0x4d0f7d5d = _0x6b65542d.Picture(_0xfe253aa7, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Rose, 0.9f), this._0x5ca6d9f3, false, 1f);
        _0x4d0f7d5d.transform.localScale = Vector3.one;
        _0x4d0f7d5d.transform.DOScale(1.08f, 1.1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        this._0xe7a9e7e6 = _0x6b65542d.Caption(_0x96df998f, _0x92ed33d3._0x56119da3(new byte[8] { 77, 110, 114, 100, 67, 110, 101, 120 }, 1), new Vector2(0.5f, 0.5f), new Vector2(900f, 150f), _0x92ed33d3._0x56119da3(new byte[34] { 191, 163, 174, 203, 169, 174, 170, 166, 203, 165, 174, 189, 174, 185, 203, 185, 174, 170, 168, 163, 174, 175, 225, 191, 163, 174, 203, 168, 185, 178, 184, 191, 170, 167 }, 235), 40f, _0xc95d1bd8.Cream, this._0xbf750ddb);
        this._0xa824d6b3 = _0x6b65542d.Caption(_0x96df998f, _0x92ed33d3._0x56119da3(new byte[9] { 40, 11, 23, 1, 33, 28, 16, 22, 5 }, 100), new Vector2(0.5f, 0.395f), new Vector2(880f, 76f), _0x92ed33d3._0x56119da3(new byte[15] { 132, 133, 142, 143, 153, 234, 134, 131, 158, 234, 250, 234, 229, 234, 250 }, 202), 38f, _0xc95d1bd8.Gold, this._0xbf750ddb);
        _0x6b65542d.ActionButton(_0x96df998f, _0x92ed33d3._0x56119da3(new byte[9] { 156, 191, 163, 181, 130, 181, 164, 162, 169 }, 208), new Vector2(0.5f, 0.245f), new Vector2(720f, 152f), _0xc95d1bd8.Beam, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.85f), _0xc95d1bd8.Cream, _0x92ed33d3._0x56119da3(new byte[5] { 195, 212, 197, 195, 200 }, 145), 50f, this._0x30068954, 1.9f, this._0xbf750ddb, () => _0x121f3876.Invoke());
        _0x6b65542d.ActionButton(_0x96df998f, _0x92ed33d3._0x56119da3(new byte[7] { 222, 253, 225, 247, 223, 243, 226 }, 146), new Vector2(0.5f, 0.1f), new Vector2(560f, 124f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Beam, 0.8f), _0xc95d1bd8.Cream, _0x92ed33d3._0x56119da3(new byte[8] { 111, 110, 101, 100, 1, 108, 96, 113 }, 33), 42f, this._0x30068954, 1.9f, this._0xbf750ddb, () => _0xf1ddf6a5.Invoke());
    }

    private void _0x30f2ef58()
    {
        if (_0x7b505880.Instance != null)
            _0x7b505880.Instance._0xa077288f();
        if (this._0x3642b0ff != null)
            this._0x3642b0ff();
    }

    private TextMeshProUGUI _0x48a70b03;
    public void _0x682bb0ca(TMP_FontAsset _0x4d79ce98, Sprite _0xa1ec9619, Sprite _0xc72efd9c, Sprite _0xba8e01b2, Sprite _0xf1b4bdf9, Sprite _0xe2fe0059, Action _0x139d7940, Action _0xd48cf513, Action _0xf5625778, Action _0x23968554, Action _0xd9671740)
    {
        if (this._0xf5b038a8 || _0x7b505880.Instance == null)
            return;
        this._0xbf750ddb = _0x4d79ce98;
        this._0x30068954 = _0xa1ec9619;
        this._0xe316d2cf = _0xc72efd9c;
        this._0xed9c3d41 = _0xba8e01b2;
        this._0x5ca6d9f3 = _0xf1b4bdf9;
        this._0x6dffb0da = _0xe2fe0059;
        this._0x3642b0ff = _0x23968554;
        _0xea6e75c9 _0x65f00c41 = _0x7b505880.Instance._0xa3b3a463(_0x3beca35c._0x9a99118c.WIN);
        _0xea6e75c9 _0xb6853ed3 = _0x7b505880.Instance._0xa3b3a463(_0x3beca35c._0x9a99118c.LOSE);
        _0xea6e75c9 _0x6b5d9813 = _0x7b505880.Instance._0xa3b3a463(_0x3beca35c._0x9a99118c.PAUSE);
        this._0xc6473604(_0x65f00c41, _0x139d7940, _0xf5625778);
        this._0xed57a54b(_0xb6853ed3, _0xd48cf513, _0xf5625778);
        this._0x0913005f(_0x6b5d9813, _0x23968554, _0xd9671740, _0xf5625778);
        this._0xf5b038a8 = true;
    }

    private TextMeshProUGUI _0x58a699fe;
    private Sprite _0xe316d2cf;
}

internal static class _0x92ed33d3
{
    internal static string _0x56119da3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}