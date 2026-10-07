using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the splash: a dark wash over the menu art, three slowly turning rays and
/// the abstract prism mark. The game's name appears nowhere here or anywhere else -
/// the brand is the mark, the palette and nothing besides.
///
/// The splash is also deliberately DARKER and emptier than the menu, so the two
/// screens never read as the same frame.
/// </summary>
public sealed class _0xa88bda62 : MonoBehaviour
{
    public void _0xc4180a93()
    {
        if (this._0x252937d7 || _0x72c0b5aa.Instance == null || _0x72c0b5aa.Instance.Content == null)
            return;
        Transform _0xe71236d8 = _0x72c0b5aa.Instance.Content.transform;
        // Wake whatever the template left asleep in the body; the loading bar is one.
        for (int _0x443408eb = 0; _0x443408eb < _0xe71236d8.childCount; _0x443408eb++)
            _0xe71236d8.GetChild(_0x443408eb).gameObject.SetActive(true);
        // Rule G: the template ships the fill white and the track (the Image on
        // "Fill Area") at alpha 0.004, so even a woken bar is invisible. Fill takes
        // the accent, the track a solid dark palette colour. The root is NOT resized:
        // "Fill Area" insets itself and a smaller root collapses the bar to nothing.
        Slider _0xd027a591 = _0xe71236d8.GetComponentInChildren<Slider>(true);
        if (_0xd027a591 != null && _0xd027a591.fillRect != null)
        {
            Image _0x250899d6 = _0xd027a591.fillRect.GetComponent<Image>();
            if (_0x250899d6 != null)
                _0x250899d6.color = _0xc95d1bd8.Beam;
            Transform _0x95cdcebe = _0xd027a591.fillRect.parent;
            Image _0x4a041bcd = _0x95cdcebe != null ? _0x95cdcebe.GetComponent<Image>() : null;
            if (_0x4a041bcd != null)
                _0x4a041bcd.color = _0xc95d1bd8.VioletDeep;
        }

        RectTransform _0x1f4a2b22 = _0x6b65542d.Sheet(_0xe71236d8, _0x70fe9203._0x0b504f87(new byte[11] { 148, 183, 171, 166, 180, 175, 148, 179, 166, 160, 162 }, 199));
        _0x1f4a2b22.SetAsFirstSibling();
        RectTransform _0x89a80f94 = _0x6b65542d.Sheet(_0x1f4a2b22, _0x70fe9203._0x0b504f87(new byte[10] { 234, 201, 213, 216, 202, 209, 238, 216, 202, 209 }, 185));
        _0x6b65542d.Picture(_0x89a80f94, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.NightDeep, 0.9f), null, false, 1f);
        RectTransform _0xf744699b = _0x6b65542d.Node(_0x1f4a2b22, _0x70fe9203._0x0b504f87(new byte[10] { 24, 59, 39, 42, 56, 35, 25, 42, 50, 56 }, 75), new Vector2(0.5f, 0.56f), new Vector2(960f, 960f));
        for (int _0xfdcadda1 = 0; _0xfdcadda1 < 3; _0xfdcadda1++)
        {
            RectTransform _0x3b13fee7 = _0x6b65542d.Node(_0xf744699b, _0x70fe9203._0x0b504f87(new byte[9] { 237, 206, 210, 223, 205, 214, 236, 223, 199 }, 190) + _0xfdcadda1.ToString(), new Vector2(0.5f, 0.5f), new Vector2(920f, 150f));
            _0x3b13fee7.localRotation = Quaternion.Euler(0f, 0f, 60f * _0xfdcadda1);
            _0x6b65542d.Picture(_0x3b13fee7, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Beam, 0.2f), this._raySprite, false, 1f);
        }

        _0xf744699b.DOLocalRotate(new Vector3(0f, 0f, 360f), 26f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
        RectTransform _0xc30eee7d = _0x6b65542d.Node(_0x1f4a2b22, _0x70fe9203._0x0b504f87(new byte[10] { 145, 178, 174, 163, 177, 170, 143, 163, 176, 169 }, 194), new Vector2(0.5f, 0.56f), new Vector2(500f, 500f));
        _0x6b65542d.Picture(_0xc30eee7d, _0xc95d1bd8.Cream, this._markSprite, false, 1f);
        _0xc30eee7d.localScale = Vector3.one * 0.86f;
        _0xc30eee7d.DOScale(1f, 0.46f).SetEase(Ease.OutBack).OnComplete(() => Breathe(_0xc30eee7d));
        _0x6b65542d.Caption(_0x1f4a2b22, _0x70fe9203._0x0b504f87(new byte[10] { 44, 15, 19, 30, 12, 23, 55, 22, 17, 11 }, 127), new Vector2(0.5f, 0.345f), new Vector2(760f, 74f), _0x70fe9203._0x0b504f87(new byte[18] { 121, 123, 118, 115, 120, 104, 123, 110, 115, 116, 125, 26, 117, 106, 110, 115, 121, 105 }, 58), 38f, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.85f), this._font);
        this._0x252937d7 = true;
    }

    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _markSprite;
    [SerializeField]
    private Sprite _raySprite;
    private static void Breathe(RectTransform _0xb6d30111)
    {
        if (_0xb6d30111 == null)
            return;
        _0xb6d30111.DOScale(1.03f, 1.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private bool _0x252937d7;
}

internal static class _0x70fe9203
{
    internal static string _0x0b504f87(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}