using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Builds the whole menu into the template's DefaultPanel body.
///
/// The template's Play target is a prefab instance that already carries the scene
/// loader, so it is the ONE child the sweep keeps: this class draws its face inside
/// it and lets the template's own driver do the loading. Nothing here calls
/// LoadSceneByIndex for Play - that would load the scene twice.
///
/// Every Image this template ships has its raycast target switched off, which leaves
/// the Play button physically unpressable; the face drawn here raycasts on purpose,
/// and UGUI passes the click up to the Button above it.
/// </summary>
public sealed class _0x647c1345 : MonoBehaviour
{
    private void _0xd14b304f()
    {
        if (this._map != null)
            this._map._0x94dd636b();
        if (this._howTo != null)
            this._howTo._0xed4bf2ec();
    }

    [SerializeField]
    private _0x80c0e8e5 _howTo;
    private void _0xd26b090f()
    {
        if (this._0x3b6b978b != null)
            this._0x3b6b978b.text = _0x883cd084._0x8ebe729a(new byte[7] { 217, 194, 203, 216, 206, 217, 170 }, 138) + this._0x9cc6fc12._0x7bf24d85.ToString();
        if (this._0x727d059e != null)
            this._0x727d059e.text = _0x883cd084._0x8ebe729a(new byte[11] { 2, 20, 18, 5, 30, 3, 113, 24, 113, 124, 113 }, 81) + this._0x9cc6fc12._0x029855c3().ToString(_0x883cd084._0x8ebe729a(new byte[2] { 239, 239 }, 223)) + _0x883cd084._0x8ebe729a(new byte[3] { 67, 76, 67 }, 99) + _0xabb6ba5f.LevelCount.ToString(_0x883cd084._0x8ebe729a(new byte[2] { 73, 73 }, 121)) + _0x883cd084._0x8ebe729a(new byte[10] { 8, 102, 103, 108, 109, 123, 8, 100, 97, 124 }, 40);
    }

    [SerializeField]
    private _0xa88bda62 _splash;
    private void _0xc0ca042d()
    {
        if (this._howTo != null)
            this._howTo._0xc0850c4c();
        if (this._map != null)
            this._map._0x9cce47f0(this._0x9cc6fc12);
    }

    private void _0x2571968a(int _0xdac1feac)
    {
        this._0x9cc6fc12._0x9bc90056 = _0xdac1feac;
        if (this._map != null)
            this._map._0x94dd636b();
        if (_0x940c8b68.Instance != null)
            _0x940c8b68.Instance.LoadSceneByIndex(_0x3beca35c._0xc6939daa.SCENE_1);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private TextMeshProUGUI _0x727d059e;
    private void _0x69ef527b(Transform _0x4843a2eb)
    {
        Image _0x46e049b1 = _0x6b65542d.Plate(_0x4843a2eb, _0x883cd084._0x8ebe729a(new byte[10] { 118, 77, 68, 87, 65, 117, 73, 68, 81, 64 }, 37), new Vector2(0.27f, 0.935f), new Vector2(420f, 96f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.NightDeep, 0.78f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Gold, 0.55f), this._plateSprite, 2.4f);
        this._0x3b6b978b = _0x6b65542d.Caption(_0x46e049b1.rectTransform, _0x883cd084._0x8ebe729a(new byte[10] { 5, 62, 55, 36, 50, 26, 55, 52, 51, 58 }, 86), new Vector2(0.5f, 0.5f), new Vector2(380f, 72f), _0x883cd084._0x8ebe729a(new byte[8] { 107, 112, 121, 106, 124, 107, 24, 8 }, 56), 46f, _0xc95d1bd8.Gold, this._font);
        // the abstract mark: the brand is a symbol, never the name (hard rule 1)
        RectTransform _0x547c1d84 = _0x6b65542d.Node(_0x4843a2eb, _0x883cd084._0x8ebe729a(new byte[8] { 110, 70, 77, 86, 110, 66, 81, 72 }, 35), new Vector2(0.5f, 0.7f), new Vector2(400f, 400f));
        _0x6b65542d.Picture(_0x547c1d84, _0xc95d1bd8.Beam, this._markSprite, false, 1f);
        _0x547c1d84.DOLocalRotate(new Vector3(0f, 0f, -360f), 26f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
        _0x6b65542d.Caption(_0x4843a2eb, _0x883cd084._0x8ebe729a(new byte[13] { 194, 234, 225, 250, 192, 237, 229, 234, 236, 251, 230, 249, 234 }, 143), new Vector2(0.5f, 0.56f), new Vector2(1000f, 150f), _0x883cd084._0x8ebe729a(new byte[33] { 51, 46, 52, 53, 36, 65, 53, 41, 36, 65, 35, 36, 32, 44, 107, 53, 41, 51, 46, 52, 38, 41, 65, 36, 55, 36, 51, 56, 65, 47, 46, 37, 36 }, 97), 44f, _0xc95d1bd8.Cream, this._font);
    }

    private TextMeshProUGUI _0x3b6b978b;
    [SerializeField]
    private Sprite _plateSprite;
    [SerializeField]
    private RectTransform _playButtonRect;
    /// <summary>
    /// Gives the template's invisible Play target a face and, crucially, a raycast
    /// target: without one no tap ever reaches the Button, because every template
    /// Image in this tarball has raycasting switched off.
    /// </summary>
    private void _0xaa06c55f()
    {
        if (this._playButtonRect == null)
            return;
        // The face is parented to the BUTTON itself, never to a rect above it: a
        // raycasting graphic only bubbles its click to an ANCESTOR Button, so hanging
        // it anywhere else would cover the control instead of giving it a face.
        Button _0x68376781 = this._playButtonRect.GetComponentInChildren<Button>(true);
        Transform _0xb811965b = _0x68376781 != null ? _0x68376781.transform : this._playButtonRect.transform;
        RectTransform _0xf354493c = _0x6b65542d.Sheet(_0xb811965b, _0x883cd084._0x8ebe729a(new byte[8] { 124, 64, 77, 85, 106, 77, 79, 73 }, 44));
        Image _0xe5d2666a = _0x6b65542d.Picture(_0xf354493c, _0xc95d1bd8.Beam, this._plateSprite, this._plateSprite != null, 1.9f);
        _0xe5d2666a.raycastTarget = true;
        RectTransform _0xd9fa2ba9 = _0x6b65542d.Sheet(_0xf354493c, _0x883cd084._0x8ebe729a(new byte[7] { 85, 105, 100, 124, 87, 108, 104 }, 5));
        _0x6b65542d.Picture(_0xd9fa2ba9, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.9f), this._plateSprite, this._plateSprite != null, 3.2f);
        _0x6b65542d.Caption(_0xf354493c, _0x883cd084._0x8ebe729a(new byte[9] { 47, 19, 30, 6, 51, 30, 29, 26, 19 }, 127), new Vector2(0.5f, 0.5f), new Vector2(620f, 104f), _0x883cd084._0x8ebe729a(new byte[4] { 254, 226, 239, 247 }, 174), 72f, _0xc95d1bd8.Cream, this._font);
        if (_0x68376781 == null)
            return;
        Transform _0x6c97ec1e = _0xf354493c;
        _0x68376781.onClick.AddListener(() => _0x6b65542d.Punch(_0x6c97ec1e));
    }

    // ----------------------------------------------------------------------- acts
    private void _0xff13ab47()
    {
        if (this._howTo != null)
            this._howTo._0xc0850c4c();
        if (this._map != null)
            this._map._0x9cce47f0(this._0x9cc6fc12);
    }

    [SerializeField]
    private _0x23579075 _map;
    [SerializeField]
    private Sprite _markSprite;
    private void _0xce02ff9f(Transform _0x77cd3e38)
    {
        this._0xaa06c55f();
        Button _0x5adc9b87 = _0x6b65542d.ActionButton(_0x77cd3e38, _0x883cd084._0x8ebe729a(new byte[13] { 167, 143, 132, 159, 167, 139, 154, 168, 159, 158, 158, 133, 132 }, 234), new Vector2(0.5f, 0.215f), new Vector2(560f, 124f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.88f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Beam, 0.85f), _0xc95d1bd8.Cream, _0x883cd084._0x8ebe729a(new byte[8] { 9, 8, 3, 2, 103, 10, 6, 23 }, 71), 46f, this._plateSprite, 1.9f, this._font, () => this._0xff13ab47());
        Button _0x754a5430 = _0x6b65542d.ActionButton(_0x77cd3e38, _0x883cd084._0x8ebe729a(new byte[15] { 181, 157, 150, 141, 176, 151, 143, 172, 151, 186, 141, 140, 140, 151, 150 }, 248), new Vector2(0.5f, 0.145f), new Vector2(480f, 110f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Night, 0.8f), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f), _0xc95d1bd8.BeamPale, _0x883cd084._0x8ebe729a(new byte[11] { 175, 168, 176, 199, 179, 168, 199, 183, 171, 166, 190 }, 231), 42f, this._plateSprite, 1.9f, this._font, () => this._0xd14b304f());
        this._0x727d059e = _0x6b65542d.Caption(_0x77cd3e38, _0x883cd084._0x8ebe729a(new byte[12] { 253, 213, 222, 197, 224, 194, 223, 215, 194, 213, 195, 195 }, 176), new Vector2(0.5f, 0.082f), new Vector2(960f, 60f), _0x883cd084._0x8ebe729a(new byte[28] { 10, 28, 26, 13, 22, 11, 121, 16, 121, 116, 121, 105, 105, 121, 118, 121, 104, 107, 121, 23, 22, 29, 28, 10, 121, 21, 16, 13 }, 89), 38f, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.85f), this._font);
        _0x6b65542d.FadeIn(_0x5adc9b87.GetComponent<RectTransform>(), 0.06f);
        _0x6b65542d.FadeIn(_0x754a5430.GetComponent<RectTransform>(), 0.12f);
        _0x6b65542d.FadeIn(this._0x727d059e.rectTransform, 0.18f);
    }

    private void Start()
    {
        if (this._splash != null)
            this._splash._0xc4180a93();
        Transform _0x8497ce73 = _0x6b65542d.PanelBody(_0x3beca35c._0x7817e4f1.DEFAULT);
        if (_0x8497ce73 == null)
            return;
        _0x6b65542d.ClearChildrenExcept(_0x8497ce73, this._playButtonRect);
        this._0x69ef527b(_0x8497ce73);
        this._0xce02ff9f(_0x8497ce73);
        if (this._map != null)
            this._map._0x7eaddc72(_0x8497ce73, this._0x9cc6fc12, (int _0x19c88c13) => this._0x2571968a(_0x19c88c13));
        if (this._howTo != null)
            this._howTo._0x8a85c235(_0x8497ce73, () => this._0xc0ca042d());
        this._0xd26b090f();
        _0x6b65542d.BlankTemplateTutorials();
    }

    private readonly _0x194db6fe _0x9cc6fc12 = new _0x194db6fe();
}

internal static class _0x883cd084
{
    internal static string _0x8ebe729a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}