using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The in-game readout, built from scratch into the template's panel body. The
/// template's own top bar and score chrome are switched off before this runs, so the
/// screen carries ONE consistent set of controls rather than template chrome with
/// generated chrome beside it (rule H, option 2).
///
/// Rule C.25: inside the moves card the big number and its caption occupy two
/// columns that never overlap - the number spans -302..-62 of the 760-wide card and
/// the caption starts at -33, a 29 px gutter, both inside the 24 px padding.
/// </summary>
public sealed class _0x79aea613 : MonoBehaviour
{
    private TextMeshProUGUI _0xc43a25ef;
    private const float HintHoldSeconds = 14f;
    private TextMeshProUGUI _0x2430f476;
    private readonly List<Image> _0xc59fa576 = new List<Image>(4);
    private Image _0x8ccfb6e5;
    private TextMeshProUGUI _0xcb7fc512;
    /// <summary>
    /// The hint dims after a while but never leaves: review reads this build from
    /// screenshots, and an explanation that has faded out is not an explanation.
    /// </summary>
    private void _0xdaf303f9()
    {
        _0x9063a020.FadeTo(this._0x83db4f75, 0.45f, 0.9f, HintHoldSeconds);
    }

    public void _0x80e94f2a(string _0x586d8ffa, Color _0x5989b8dd)
    {
        if (this._0x4c838ed2 == null)
            return;
        this._0x4c838ed2.text = _0x586d8ffa;
        this._0x4c838ed2.color = _0x5989b8dd;
        this._0x4c838ed2.alpha = 1f;
        _0x9063a020.FadeTo(this._0x4c838ed2, 0f, 0.6f, 1.6f);
    }

    /// <summary>The overload wash: a full-screen rose pulse that reads on a still frame.</summary>
    public void _0xe0706663()
    {
        if (this._0x8ccfb6e5 == null)
            return;
        Image _0xe2097400 = this._0x8ccfb6e5;
        DOTween.Kill(_0xe2097400);
        _0xe2097400.color = _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Rose, 0f);
        Sequence _0x52c91ee4 = DOTween.Sequence().SetId(_0xe2097400);
        _0x52c91ee4.Append(_0xe2097400.DOFade(0.35f, 0.14f));
        _0x52c91ee4.Append(_0xe2097400.DOFade(0f, 0.26f));
    }

    /// <summary>One pip per required checkpoint; unused pips are switched off, not left blank.</summary>
    public void _0xd2e5109d(int _0x891ca97f, int _0xd8611ca2)
    {
        if (this._0xcb7fc512 != null)
            this._0xcb7fc512.text = _0xeb9245b1._0x6549f3d2(new byte[12] { 129, 138, 135, 129, 137, 146, 141, 139, 140, 150, 145, 226 }, 194) + _0xd8611ca2.ToString() + _0xeb9245b1._0x6549f3d2(new byte[3] { 25, 22, 25 }, 57) + _0x891ca97f.ToString();
        for (int _0xc40c03a5 = 0; _0xc40c03a5 < this._0xc59fa576.Count; _0xc40c03a5++)
        {
            Image _0xc5264ec2 = this._0xc59fa576[_0xc40c03a5];
            if (_0xc5264ec2 == null)
                continue;
            bool _0x83e6a946 = _0xc40c03a5 < _0x891ca97f;
            _0xc5264ec2.gameObject.SetActive(_0x83e6a946);
            if (!_0x83e6a946)
                continue;
            Color _0xbfa5e46c = _0xc40c03a5 < _0xd8611ca2 ? _0xc95d1bd8.BeamPale : _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f);
            if (_0xc5264ec2.color != _0xbfa5e46c)
            {
                Transform _0x2527a77f = _0xc5264ec2.transform;
                DOTween.Kill(_0x2527a77f);
                _0x2527a77f.localScale = Vector3.one;
                _0x2527a77f.DOPunchScale(Vector3.one * 0.3f, 0.26f, 1, 0.5f);
            }

            _0xc5264ec2.color = _0xbfa5e46c;
        }

        // the row is centred on however many pips are really in play
        for (int _0x96ad0b4a = 0; _0x96ad0b4a < this._0xc59fa576.Count; _0x96ad0b4a++)
        {
            Image _0x6e288d1c = this._0xc59fa576[_0x96ad0b4a];
            if (_0x6e288d1c == null || _0x96ad0b4a >= _0x891ca97f)
                continue;
            RectTransform _0x94aa3f21 = _0x6e288d1c.rectTransform;
            _0x94aa3f21.anchorMin = new Vector2(0.5f + (_0x96ad0b4a - (_0x891ca97f - 1) * 0.5f) * 0.062f, 0.745f);
            _0x94aa3f21.anchorMax = _0x94aa3f21.anchorMin;
            _0x94aa3f21.anchoredPosition = Vector2.zero;
        }
    }

    public void _0xf54c096e(int _0xec25f0d6)
    {
        if (this._0x128078e1 != null)
            this._0x128078e1.text = _0xeb9245b1._0x6549f3d2(new byte[5] { 245, 244, 255, 254, 155 }, 187) + (_0xec25f0d6 + 1).ToString(_0xeb9245b1._0x6549f3d2(new byte[2] { 192, 192 }, 240)) + _0xeb9245b1._0x6549f3d2(new byte[11] { 65, 76, 65, 50, 36, 34, 53, 46, 51, 65, 40 }, 97);
    }

    private TextMeshProUGUI _0x83db4f75;
    /// <summary>
    /// Builds the HUD and returns the tap catcher. The catcher is created FIRST, so
    /// every control added after it is a later sibling and takes the raycast; only
    /// taps that miss the controls reach the lattice.
    /// </summary>
    public _0xa25c9eec _0x94050be0(Transform _0x56734d58, Camera _0x7286974d, TMP_FontAsset _0x7a88c3a9, Sprite _0x1df456a8, Sprite _0xf406f413, Sprite _0xeb02843b, Sprite _0xac7feddc, Action _0x67c08aea, Action _0x2a1f188c, Action<Vector3> _0x3d5ae1a6)
    {
        this._0xd2d5a8d7 = _0xac7feddc;
        RectTransform _0x5d42844a = _0x6b65542d.Sheet(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[14] { 188, 145, 132, 132, 153, 147, 149, 164, 145, 128, 177, 130, 149, 145 }, 240));
        Image _0xfda12b4e = _0x5d42844a.gameObject.AddComponent<Image>();
        _0xfda12b4e.color = new Color(1f, 1f, 1f, 0.004f);
        _0xfda12b4e.raycastTarget = true;
        _0xfda12b4e.canvasRenderer.cullTransparentMesh = false;
        _0xa25c9eec _0x7fa8cd3b = _0x5d42844a.gameObject.AddComponent<_0xa25c9eec>();
        _0x7fa8cd3b._0x5fda9025(_0x7286974d, _0x3d5ae1a6);
        // top bar
        _0x6b65542d.Plate(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[6] { 104, 83, 76, 126, 93, 78 }, 60), new Vector2(0.5f, 0.92f), new Vector2(1160f, 146f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.NightDeep, 0.78f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.6f), _0x1df456a8, 1.5f);
        _0x6b65542d.IconButton(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[10] { 82, 113, 115, 123, 82, 101, 100, 100, 127, 126 }, 16), new Vector2(0.108f, 0.92f), new Vector2(124f, 124f), _0xf406f413, _0xc95d1bd8.Beam, () => _0x67c08aea.Invoke());
        this._0x128078e1 = _0x6b65542d.Caption(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[9] { 135, 166, 173, 172, 133, 168, 171, 172, 165 }, 201), new Vector2(0.5f, 0.92f), new Vector2(560f, 76f), _0xeb9245b1._0x6549f3d2(new byte[18] { 129, 128, 139, 138, 239, 255, 254, 239, 226, 239, 156, 138, 140, 155, 128, 157, 239, 134 }, 207), 42f, _0xc95d1bd8.Cream, _0x7a88c3a9);
        _0x6b65542d.IconButton(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[11] { 245, 196, 208, 214, 192, 231, 208, 209, 209, 202, 203 }, 165), new Vector2(0.892f, 0.92f), new Vector2(124f, 124f), _0xeb02843b, _0xc95d1bd8.Beam, () => _0x2a1f188c.Invoke());
        // moves card: number column left, caption column right, 29 px gutter (C.25)
        Image _0xe4583d8d = _0x6b65542d.Plate(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[9] { 120, 90, 67, 80, 70, 118, 84, 71, 81 }, 53), new Vector2(0.5f, 0.845f), new Vector2(760f, 156f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Night, 0.86f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Beam, 0.75f), _0x1df456a8, 1.9f);
        this._0x2430f476 = _0x6b65542d.Caption(_0xe4583d8d.rectTransform, _0xeb9245b1._0x6549f3d2(new byte[10] { 231, 197, 220, 207, 217, 252, 203, 198, 223, 207 }, 170), new Vector2(0.26f, 0.5f), new Vector2(240f, 112f), _0xeb9245b1._0x6549f3d2(new byte[2] { 153, 153 }, 169), 78f, _0xc95d1bd8.Gold, _0x7a88c3a9);
        this._0xc43a25ef = _0x6b65542d.Caption(_0xe4583d8d.rectTransform, _0xeb9245b1._0x6549f3d2(new byte[12] { 124, 94, 71, 84, 66, 114, 80, 65, 69, 88, 94, 95 }, 49), new Vector2(0.68f, 0.5f), new Vector2(340f, 70f), _0xeb9245b1._0x6549f3d2(new byte[10] { 133, 135, 158, 141, 155, 232, 132, 141, 142, 156 }, 200), 34f, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.85f), _0x7a88c3a9);
        // checkpoint chain: caption ABOVE the row, so no text shares an x band with a pip
        this._0xcb7fc512 = _0x6b65542d.Caption(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[12] { 201, 226, 239, 233, 225, 201, 235, 250, 254, 227, 229, 228 }, 138), new Vector2(0.5f, 0.788f), new Vector2(520f, 56f), _0xeb9245b1._0x6549f3d2(new byte[17] { 207, 196, 201, 207, 199, 220, 195, 197, 194, 216, 223, 172, 188, 172, 163, 172, 188 }, 140), 34f, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.85f), _0x7a88c3a9);
        for (int _0x7f4404c7 = 0; _0x7f4404c7 < 4; _0x7f4404c7++)
        {
            RectTransform _0xf09e7042 = _0x6b65542d.Node(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[8] { 56, 19, 30, 24, 16, 43, 18, 11 }, 123) + _0x7f4404c7.ToString(), new Vector2(0.5f + (_0x7f4404c7 - 1.5f) * 0.062f, 0.745f), new Vector2(54f, 54f));
            Image _0x41c71c40 = _0x6b65542d.Picture(_0xf09e7042, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f), _0xac7feddc, false, 1f);
            this._0xc59fa576.Add(_0x41c71c40);
            _0xf09e7042.gameObject.SetActive(false);
        }

        // the running commentary of the board, under the lattice
        this._0x4c838ed2 = _0x6b65542d.Caption(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[9] { 114, 80, 93, 93, 125, 80, 83, 84, 93 }, 49), new Vector2(0.5f, 0.192f), new Vector2(980f, 70f), string.Empty, 40f, _0xc95d1bd8.BeamPale, _0x7a88c3a9);
        // control explanation: mandatory, and it never leaves the screen (C.6)
        this._0x83db4f75 = _0x6b65542d.Caption(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[11] { 142, 162, 163, 185, 191, 162, 161, 133, 164, 163, 185 }, 205), new Vector2(0.5f, 0.115f), new Vector2(1030f, 124f), _0xeb9245b1._0x6549f3d2(new byte[38] { 70, 83, 66, 50, 83, 92, 75, 50, 95, 91, 64, 64, 93, 64, 50, 90, 87, 74, 24, 70, 93, 50, 70, 71, 64, 92, 50, 91, 70, 50, 93, 92, 87, 50, 65, 70, 87, 66 }, 18), 40f, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.92f), _0x7a88c3a9);
        // screen-wide overload wash, last so it covers the board, and never raycasts
        RectTransform _0x42fe851b = _0x6b65542d.Sheet(_0x56734d58, _0xeb9245b1._0x6549f3d2(new byte[13] { 15, 54, 37, 50, 44, 47, 33, 36, 6, 44, 33, 51, 40 }, 64));
        this._0x8ccfb6e5 = _0x6b65542d.Picture(_0x42fe851b, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Rose, 0f), null, false, 1f);
        this._0xdaf303f9();
        return _0x7fa8cd3b;
    }

    private Sprite _0xd2d5a8d7;
    private TextMeshProUGUI _0x128078e1;
    private TextMeshProUGUI _0x4c838ed2;
    public void _0xaedbba74(int _0x4d97f883, bool _0x978c62b4)
    {
        if (this._0x2430f476 == null)
            return;
        this._0x2430f476.text = Mathf.Max(0, _0x4d97f883).ToString(_0xeb9245b1._0x6549f3d2(new byte[2] { 3, 3 }, 51));
        this._0x2430f476.color = _0x4d97f883 <= 2 ? _0xc95d1bd8.Rose : _0xc95d1bd8.Gold;
        if (!_0x978c62b4)
            return;
        Transform _0x594d39bd = this._0x2430f476.transform;
        DOTween.Kill(_0x594d39bd);
        _0x594d39bd.localScale = Vector3.one;
        _0x594d39bd.DOPunchScale(Vector3.one * 0.14f, 0.26f, 1, 0.5f);
    }
}

internal static class _0xeb9245b1
{
    internal static string _0x6549f3d2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}