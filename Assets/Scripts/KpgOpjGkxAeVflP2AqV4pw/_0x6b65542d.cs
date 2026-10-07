using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// Runtime UGUI construction kit. Every screen of this game is built into a template
/// panel body, so nothing here ever looks an object up by name - callers keep the
/// RectTransforms they made.
///
/// Draw order is positional (C.13): each helper adds its background plate FIRST and
/// its label LAST, so a caption is always a later sibling than the plate behind it.
/// </summary>
public static class _0x6b65542d
{
    /// <summary>Fades a block in from slightly below; used for the menu entry cascade.</summary>
    public static void FadeIn(RectTransform _0xa87d3a03, float _0x88fc4add)
    {
        if (_0xa87d3a03 == null)
            return;
        CanvasGroup _0x20f8c611 = _0xa87d3a03.gameObject.AddComponent<CanvasGroup>();
        _0x20f8c611.alpha = 0f;
        Vector2 _0x283febff = _0xa87d3a03.anchoredPosition;
        _0xa87d3a03.anchoredPosition = _0x283febff + new Vector2(0f, -40f);
        DOTween.To(() => _0x20f8c611.alpha, (float _0xde775227) => _0x20f8c611.alpha = _0xde775227, 1f, 0.24f).SetDelay(_0x88fc4add);
        _0xa87d3a03.DOAnchorPos(_0x283febff, 0.28f).SetDelay(_0x88fc4add).SetEase(Ease.OutCubic);
    }

    /// <summary>A box stretched over the whole of its parent.</summary>
    public static RectTransform Sheet(Transform _0xecfb1114, string _0x507967dd)
    {
        GameObject _0xc2989284 = new GameObject(_0x507967dd, typeof(RectTransform));
        RectTransform _0xbcf6bf3c = _0xc2989284.GetComponent<RectTransform>();
        _0xbcf6bf3c.SetParent(_0xecfb1114, false);
        _0xbcf6bf3c.anchorMin = Vector2.zero;
        _0xbcf6bf3c.anchorMax = Vector2.one;
        _0xbcf6bf3c.pivot = new Vector2(0.5f, 0.5f);
        _0xbcf6bf3c.offsetMin = Vector2.zero;
        _0xbcf6bf3c.offsetMax = Vector2.zero;
        _0xbcf6bf3c.localScale = Vector3.one;
        return _0xbcf6bf3c;
    }

    /// <summary>A themed plate: fill first, then a rim of its own so the edge reads on any backdrop.</summary>
    public static Image Plate(Transform _0x81a10832, string _0x69b1a44c, Vector2 _0xfe1e5335, Vector2 _0x26c02d53, Color _0x82044a89, Color _0xaf8f83b8, Sprite _0x1745e26d, float _0x8d846ca2)
    {
        RectTransform _0xd131ea1f = Node(_0x81a10832, _0x69b1a44c, _0xfe1e5335, _0x26c02d53);
        Image _0xd2cf4d79 = Picture(_0xd131ea1f, _0x82044a89, _0x1745e26d, _0x1745e26d != null, _0x8d846ca2);
        if (_0xaf8f83b8.a > 0f)
        {
            RectTransform _0x5d95390f = Sheet(_0xd131ea1f, _0x69b1a44c + _0xd4aad3e8._0xae80daa1(new byte[3] { 107, 80, 84 }, 57));
            Picture(_0x5d95390f, _0xaf8f83b8, _0x1745e26d, _0x1745e26d != null, _0x8d846ca2 * 1.7f);
        }

        return _0xd2cf4d79;
    }

    /// <summary>
    /// A tappable button: plate, rim, caption on top. The press tint plus the punch on
    /// release are the visible acknowledgement rule C.7 asks for.
    /// </summary>
    public static Button ActionButton(Transform _0xa684944d, string _0xe13eea33, Vector2 _0x38707cda, Vector2 _0x1bbe087c, Color _0x56b36ab7, Color _0xce3088ab, Color _0x66122ad7, string _0x27e8217d, float _0x41208a73, Sprite _0x79e438c2, float _0xaa031d44, TMP_FontAsset _0x2da96cf5, UnityAction _0xfd5103c5)
    {
        RectTransform _0x974264d4 = Node(_0xa684944d, _0xe13eea33, _0x38707cda, _0x1bbe087c);
        Image _0x5472ad7f = Picture(_0x974264d4, _0x56b36ab7, _0x79e438c2, _0x79e438c2 != null, _0xaa031d44);
        _0x5472ad7f.raycastTarget = true;
        if (_0xce3088ab.a > 0f)
        {
            RectTransform _0x67849775 = Sheet(_0x974264d4, _0xe13eea33 + _0xd4aad3e8._0xae80daa1(new byte[3] { 18, 41, 45 }, 64));
            Picture(_0x67849775, _0xce3088ab, _0x79e438c2, _0x79e438c2 != null, _0xaa031d44 * 1.7f);
        }

        if (!string.IsNullOrEmpty(_0x27e8217d))
            Caption(_0x974264d4, _0xe13eea33 + _0xd4aad3e8._0xae80daa1(new byte[4] { 55, 6, 27, 23 }, 99), new Vector2(0.5f, 0.5f), new Vector2(_0x1bbe087c.x - 56f, _0x1bbe087c.y * 0.62f), _0x27e8217d, _0x41208a73, _0x66122ad7, _0x2da96cf5);
        Button _0x42ddc4c1 = _0x974264d4.gameObject.AddComponent<Button>();
        _0x42ddc4c1.targetGraphic = _0x5472ad7f;
        _0x42ddc4c1.transition = Selectable.Transition.ColorTint;
        ColorBlock _0x75433c77 = _0x42ddc4c1.colors;
        _0x75433c77.normalColor = Color.white;
        _0x75433c77.highlightedColor = Color.white;
        _0x75433c77.pressedColor = new Color(0.70f, 0.74f, 0.80f, 1f);
        _0x75433c77.selectedColor = Color.white;
        _0x75433c77.disabledColor = new Color(0.42f, 0.44f, 0.52f, 0.6f);
        _0x75433c77.fadeDuration = 0.08f;
        _0x42ddc4c1.colors = _0x75433c77;
        Transform _0x90dbf65b = _0x974264d4;
        _0x42ddc4c1.onClick.AddListener(() => Punch(_0x90dbf65b));
        if (_0xfd5103c5 != null)
            _0x42ddc4c1.onClick.AddListener(() => _0xfd5103c5.Invoke());
        return _0x42ddc4c1;
    }

    /// <summary>Blanks every label under a container - template filler must never reach a screen.</summary>
    public static void BlankLabels(Transform _0xb846175c)
    {
        if (_0xb846175c == null)
            return;
        TMP_Text[] _0xed3a1faf = _0xb846175c.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x1f39c93c = 0; _0x1f39c93c < _0xed3a1faf.Length; _0x1f39c93c++)
            if (_0xed3a1faf[_0x1f39c93c] != null)
                _0xed3a1faf[_0x1f39c93c].text = string.Empty;
    }

    /// <summary>
    /// The body of one template panel, reached through the public Panels list.
    /// PanelController.GetPanel is private in this template, so the list is the only
    /// obfuscation-safe handle.
    /// </summary>
    public static Transform PanelBody(int _0x8bb4e603)
    {
        if (_0x7ed5945d.Instance == null)
            return null;
        System.Collections.Generic.List<_0xf221fccc> _0x73882079 = _0x7ed5945d.Instance.Panels;
        if (_0x73882079 == null || _0x8bb4e603 < 0 || _0x8bb4e603 >= _0x73882079.Count)
            return null;
        _0xf221fccc _0x11f051cd = _0x73882079[_0x8bb4e603];
        if (_0x11f051cd == null || _0x11f051cd.Content == null)
            return null;
        return _0x11f051cd.Content.transform;
    }

    /// <summary>
    /// The same sweep, but one branch survives: the menu's Play target is a template
    /// prefab instance and carries the scene loader, so it must stay alive.
    /// </summary>
    public static void ClearChildrenExcept(Transform _0x10540bf6, Transform _0x2a1a7ccd)
    {
        if (_0x10540bf6 == null)
            return;
        for (int _0x7e434f13 = _0x10540bf6.childCount - 1; _0x7e434f13 >= 0; _0x7e434f13--)
        {
            Transform _0x357208e8 = _0x10540bf6.GetChild(_0x7e434f13);
            if (_0x357208e8 == null || _0x357208e8 == _0x2a1a7ccd)
                continue;
            if (_0x2a1a7ccd != null && _0x2a1a7ccd.IsChildOf(_0x357208e8))
                continue;
            _0x357208e8.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Adds an Image. A sprite carrying a 9-slice border is drawn Sliced so its corner
    /// radius survives any box size; a plain content sprite stays Simple and keeps its
    /// own aspect (F.2a).
    /// </summary>
    public static Image Picture(RectTransform _0xbb3fca96, Color _0x883d83d7, Sprite _0x548432f4, bool _0xd5adb52f, float _0x7484d9bb)
    {
        Image _0x2caa9461 = _0xbb3fca96.gameObject.AddComponent<Image>();
        _0x2caa9461.sprite = _0x548432f4;
        _0x2caa9461.color = _0x883d83d7;
        _0x2caa9461.raycastTarget = false;
        if (_0x548432f4 != null && _0xd5adb52f)
        {
            _0x2caa9461.type = Image.Type.Sliced;
            _0x2caa9461.pixelsPerUnitMultiplier = _0x7484d9bb;
        }
        else
        {
            _0x2caa9461.type = Image.Type.Simple;
            _0x2caa9461.preserveAspect = _0x548432f4 != null;
        }

        return _0x2caa9461;
    }

    /// <summary>One label. Wrapping is off - pass an explicit \n for every line break.</summary>
    public static TextMeshProUGUI Caption(Transform _0x5b50bde8, string _0xf0b1a340, Vector2 _0xff04f143, Vector2 _0x1981ef8d, string _0xae6bfbea, float _0xdd9def9b, Color _0x32fd36ad, TMP_FontAsset _0x1b8c054a)
    {
        RectTransform _0x161672be = Node(_0x5b50bde8, _0xf0b1a340, _0xff04f143, _0x1981ef8d);
        TextMeshProUGUI _0xc0fb1f0c = _0x161672be.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x1b8c054a != null)
            _0xc0fb1f0c.font = _0x1b8c054a;
        _0xc0fb1f0c.text = _0xae6bfbea;
        _0x9063a020.Dress(_0xc0fb1f0c, _0xdd9def9b, _0x32fd36ad);
        return _0xc0fb1f0c;
    }

    /// <summary>
    /// The template declares seven tutorial slots and fills them with Lorem Ipsum.
    /// Nothing in this game raises them - the three lessons live in the HOW TO PLAY
    /// sheet - so every label in all seven is blanked. The panels stay in the pool:
    /// the controllers address panels by index and a missing one breaks navigation
    /// (C.15).
    /// </summary>
    public static void BlankTemplateTutorials()
    {
        BlankPanelBody(_0x3beca35c._0x7817e4f1.TUTORIAL0);
        BlankPanelBody(_0x3beca35c._0x7817e4f1.TUTORIAL1);
        BlankPanelBody(_0x3beca35c._0x7817e4f1.TUTORIAL2);
        BlankPanelBody(_0x3beca35c._0x7817e4f1.TUTORIAL3);
        BlankPanelBody(_0x3beca35c._0x7817e4f1.TUTORIAL4);
        BlankPanelBody(_0x3beca35c._0x7817e4f1.TUTORIAL5);
        BlankPanelBody(_0x3beca35c._0x7817e4f1.TUTORIAL6);
    }

    /// <summary>An icon-only button (back, pause, close).</summary>
    public static Button IconButton(Transform _0x1f52426b, string _0xa98df91b, Vector2 _0x105f3e64, Vector2 _0x9a5235f7, Sprite _0x7c76846f, Color _0x8324d32a, UnityAction _0x8c49b02e)
    {
        RectTransform _0x3b246e1f = Node(_0x1f52426b, _0xa98df91b, _0x105f3e64, _0x9a5235f7);
        Image _0x4a0cb5c7 = _0x3b246e1f.gameObject.AddComponent<Image>();
        _0x4a0cb5c7.color = new Color(1f, 1f, 1f, 0.004f); // invisible but still raycasts
        _0x4a0cb5c7.raycastTarget = true;
        _0x4a0cb5c7.canvasRenderer.cullTransparentMesh = false;
        RectTransform _0x3f0a5bf0 = Node(_0x3b246e1f, _0xa98df91b + _0xd4aad3e8._0xae80daa1(new byte[5] { 162, 137, 156, 149, 141 }, 229), new Vector2(0.5f, 0.5f), _0x9a5235f7 * 0.68f);
        Picture(_0x3f0a5bf0, _0x8324d32a, _0x7c76846f, false, 1f);
        Button _0x2440af51 = _0x3b246e1f.gameObject.AddComponent<Button>();
        _0x2440af51.targetGraphic = _0x4a0cb5c7;
        _0x2440af51.transition = Selectable.Transition.None;
        Transform _0x44c7bc25 = _0x3f0a5bf0;
        _0x2440af51.onClick.AddListener(() => Punch(_0x44c7bc25));
        if (_0x8c49b02e != null)
            _0x2440af51.onClick.AddListener(() => _0x8c49b02e.Invoke());
        return _0x2440af51;
    }

    /// <summary>Switches off every direct child of a container, leaving the container alone.</summary>
    public static void ClearChildren(Transform _0x54ebce2b)
    {
        if (_0x54ebce2b == null)
            return;
        for (int _0xe3bba9f7 = _0x54ebce2b.childCount - 1; _0xe3bba9f7 >= 0; _0xe3bba9f7--)
        {
            Transform _0x1441c63d = _0x54ebce2b.GetChild(_0xe3bba9f7);
            if (_0x1441c63d != null)
                _0x1441c63d.gameObject.SetActive(false);
        }
    }

    /// <summary>A full-parent shade that also closes the sheet it dims.</summary>
    public static Button Shade(Transform _0xbeaecf8e, string _0xa6f59222, Color _0x5cbc3bdd, UnityAction _0xd9212d51)
    {
        RectTransform _0x7582bcde = Sheet(_0xbeaecf8e, _0xa6f59222);
        Image _0x600d9a1c = _0x7582bcde.gameObject.AddComponent<Image>();
        _0x600d9a1c.color = _0x5cbc3bdd;
        _0x600d9a1c.raycastTarget = true;
        _0x600d9a1c.canvasRenderer.cullTransparentMesh = false;
        Button _0xc4c9a0ca = _0x7582bcde.gameObject.AddComponent<Button>();
        _0xc4c9a0ca.targetGraphic = _0x600d9a1c;
        _0xc4c9a0ca.transition = Selectable.Transition.None;
        if (_0xd9212d51 != null)
            _0xc4c9a0ca.onClick.AddListener(() => _0xd9212d51.Invoke());
        return _0xc4c9a0ca;
    }

    private static void BlankPanelBody(int _0x52aafd5b)
    {
        BlankLabels(PanelBody(_0x52aafd5b));
    }

    public static void Punch(Transform _0x868c7155)
    {
        if (_0x868c7155 == null)
            return;
        DOTween.Kill(_0x868c7155);
        _0x868c7155.localScale = Vector3.one;
        _0x868c7155.DOPunchScale(new Vector3(-0.06f, -0.06f, 0f), 0.18f, 1, 0.4f).SetEase(Ease.OutQuad);
    }

    /// <summary>A point-anchored box, sized in canvas reference pixels (1242x2688).</summary>
    public static RectTransform Node(Transform _0x4cc22c46, string _0x6d8ed183, Vector2 _0xf4eb6a16, Vector2 _0x520612b0)
    {
        GameObject _0xef2f453a = new GameObject(_0x6d8ed183, typeof(RectTransform));
        RectTransform _0x5a8be21d = _0xef2f453a.GetComponent<RectTransform>();
        _0x5a8be21d.SetParent(_0x4cc22c46, false);
        _0x5a8be21d.anchorMin = _0xf4eb6a16;
        _0x5a8be21d.anchorMax = _0xf4eb6a16;
        _0x5a8be21d.pivot = new Vector2(0.5f, 0.5f);
        _0x5a8be21d.sizeDelta = _0x520612b0;
        _0x5a8be21d.anchoredPosition = Vector2.zero;
        _0x5a8be21d.localScale = Vector3.one;
        _0x5a8be21d.localRotation = Quaternion.identity;
        return _0x5a8be21d;
    }
}

internal static class _0xd4aad3e8
{
    internal static string _0xae80daa1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}