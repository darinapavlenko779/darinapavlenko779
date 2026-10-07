using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Three lessons with a live demonstration beside each: a mirror hex that keeps
/// turning, a move counter that keeps spending, and a chain of nodes that lights in
/// order. The sheet explains the one gesture this game has, so it is shown by a
/// button and replays on every launch - unlike the template tutorial, which fires
/// once per install and would desynchronise every later capture run.
///
/// Its footer does not go back to the menu: it opens the map, so the step after it
/// is a different screen (F.0b).
/// </summary>
public sealed class _0x80c0e8e5 : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this);
    }

    [SerializeField]
    private Sprite _mirrorSprite;
    public void _0x8a85c235(Transform _0x76eae851, Action _0x567bec06)
    {
        this._0xf8326def = _0x6b65542d.Sheet(_0x76eae851, _0x97e8cd6e._0x93c58dae(new byte[10] { 89, 126, 102, 69, 126, 66, 121, 116, 116, 101 }, 17));
        _0x6b65542d.Shade(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[10] { 60, 27, 3, 32, 27, 39, 28, 21, 16, 17 }, 116), _0xc95d1bd8.WithAlpha(_0xc95d1bd8.NightDeep, 0.92f), () => this._0xc0850c4c());
        RectTransform _0x32df6b9d = _0x6b65542d.Node(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[9] { 82, 117, 109, 78, 117, 89, 123, 104, 126 }, 26), new Vector2(0.5f, 0.5f), new Vector2(1040f, 1620f));
        Image _0xd5c36269 = _0x6b65542d.Picture(_0x32df6b9d, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Surface, 0.96f), this._plateSprite, this._plateSprite != null, 4.4f);
        _0xd5c36269.raycastTarget = true;
        RectTransform _0x02ec4eda = _0x6b65542d.Sheet(_0x32df6b9d, _0x97e8cd6e._0x93c58dae(new byte[8] { 119, 80, 72, 107, 80, 109, 86, 82 }, 63));
        _0x6b65542d.Picture(_0x02ec4eda, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f), this._plateSprite, this._plateSprite != null, 6.2f);
        _0x6b65542d.Caption(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[10] { 128, 167, 191, 156, 167, 156, 161, 188, 164, 173 }, 200), new Vector2(0.5f, 0.762f), new Vector2(820f, 100f), _0x97e8cd6e._0x93c58dae(new byte[11] { 53, 50, 42, 93, 41, 50, 93, 45, 49, 60, 36 }, 125), 60f, _0xc95d1bd8.Beam, this._font);
        _0x6b65542d.IconButton(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[10] { 84, 115, 107, 72, 115, 95, 112, 115, 111, 121 }, 28), new Vector2(0.845f, 0.765f), new Vector2(100f, 100f), this._closeIcon, _0xc95d1bd8.Cream, () => this._0xc0850c4c());
        // lesson one: the only gesture in the game, shown turning
        this._0xef310db1 = _0x6b65542d.Node(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[12] { 79, 104, 112, 83, 104, 67, 98, 106, 104, 79, 98, 127 }, 7), new Vector2(0.5f, 0.672f), new Vector2(200f, 200f));
        _0x6b65542d.Picture(this._0xef310db1, _0xc95d1bd8.Cream, this._mirrorSprite, false, 1f);
        RectTransform _0x5451bb26 = _0x6b65542d.Node(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[12] { 174, 137, 145, 178, 137, 182, 137, 143, 136, 146, 131, 148 }, 230), new Vector2(0.63f, 0.637f), new Vector2(92f, 92f));
        _0x6b65542d.Picture(_0x5451bb26, _0xc95d1bd8.Beam, this._tapSprite, false, 1f);
        _0x5451bb26.localScale = Vector3.one;
        _0x5451bb26.DOScale(1.14f, 0.7f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        _0x6b65542d.Caption(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[12] { 235, 204, 212, 247, 204, 240, 215, 198, 211, 236, 205, 198 }, 163), new Vector2(0.5f, 0.565f), new Vector2(900f, 150f), _0x97e8cd6e._0x93c58dae(new byte[40] { 186, 171, 171, 171, 223, 202, 219, 171, 202, 171, 198, 194, 217, 217, 196, 217, 171, 195, 206, 211, 129, 223, 196, 171, 223, 222, 217, 197, 171, 194, 223, 171, 196, 197, 206, 171, 216, 223, 206, 219 }, 139), 40f, _0xc95d1bd8.Cream, this._font);
        // lesson two: what a turn costs
        _0x6b65542d.Caption(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[12] { 176, 151, 143, 172, 151, 171, 140, 157, 136, 172, 143, 151 }, 248), new Vector2(0.5f, 0.465f), new Vector2(900f, 90f), _0x97e8cd6e._0x93c58dae(new byte[30] { 85, 71, 71, 71, 34, 49, 34, 53, 62, 71, 51, 50, 53, 41, 71, 52, 55, 34, 41, 35, 52, 71, 40, 41, 34, 71, 42, 40, 49, 34 }, 103), 40f, _0xc95d1bd8.Cream, this._font);
        this._0xf999bec2 = _0x6b65542d.Caption(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[12] { 141, 170, 178, 145, 170, 134, 170, 176, 171, 177, 160, 183 }, 197), new Vector2(0.5f, 0.412f), new Vector2(520f, 86f), _0x97e8cd6e._0x93c58dae(new byte[8] { 5, 7, 30, 13, 27, 104, 121, 122 }, 72), 50f, _0xc95d1bd8.Gold, this._font);
        // lesson three: the goal, with the chain lighting in order BELOW the words,
        // so the indicator row never shares an x band with the text (C.25)
        _0x6b65542d.Caption(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[14] { 69, 98, 122, 89, 98, 94, 121, 104, 125, 89, 101, 127, 104, 104 }, 13), new Vector2(0.5f, 0.345f), new Vector2(900f, 150f), _0x97e8cd6e._0x93c58dae(new byte[37] { 76, 95, 95, 95, 51, 54, 56, 55, 43, 95, 58, 41, 58, 45, 38, 95, 49, 48, 59, 58, 117, 43, 55, 58, 49, 95, 43, 55, 58, 95, 60, 45, 38, 44, 43, 62, 51 }, 127), 40f, _0xc95d1bd8.Cream, this._font);
        for (int _0x4bc3de96 = 0; _0x4bc3de96 < this._0x14b2c541.Length; _0x4bc3de96++)
        {
            RectTransform _0x68525b4c = _0x6b65542d.Node(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[10] { 78, 105, 113, 82, 105, 69, 110, 103, 111, 104 }, 6) + _0x4bc3de96.ToString(), new Vector2(0.39f + _0x4bc3de96 * 0.07f, 0.3f), new Vector2(62f, 62f));
            this._0x14b2c541[_0x4bc3de96] = _0x6b65542d.Picture(_0x68525b4c, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f), this._nodeSprite, false, 1f);
        }

        RectTransform _0x98459ecf = _0x6b65542d.Node(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[17] { 159, 184, 160, 131, 184, 148, 191, 182, 190, 185, 148, 165, 174, 164, 163, 182, 187 }, 215), new Vector2(0.63f, 0.3f), new Vector2(76f, 76f));
        this._0x6f19ac7e = _0x6b65542d.Picture(_0x98459ecf, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Gold, 0.3f), this._crystalSprite, false, 1f);
        _0x6b65542d.ActionButton(this._0xf8326def, _0x97e8cd6e._0x93c58dae(new byte[10] { 124, 91, 67, 96, 91, 96, 91, 121, 85, 68 }, 52), new Vector2(0.5f, 0.243f), new Vector2(620f, 132f), _0xc95d1bd8.Beam, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.85f), _0xc95d1bd8.Cream, _0x97e8cd6e._0x93c58dae(new byte[10] { 14, 21, 122, 14, 18, 31, 122, 23, 27, 10 }, 90), 50f, this._plateSprite, 1.9f, this._font, () => _0x567bec06.Invoke());
        this._0xf8326def.gameObject.SetActive(false);
    }

    private TextMeshProUGUI _0xf999bec2;
    [SerializeField]
    private Sprite _closeIcon;
    private RectTransform _0xef310db1;
    private int _0xa8376c7f;
    public void _0xed4bf2ec()
    {
        if (this._0xf8326def == null)
            return;
        this._0xf8326def.gameObject.SetActive(true);
        this._0xf8326def.localScale = Vector3.one * 0.94f;
        this._0xf8326def.DOScale(1f, 0.24f).SetEase(Ease.OutCubic);
        this._0x200525d3();
    }

    [SerializeField]
    private Sprite _nodeSprite;
    private readonly Image[] _0x14b2c541 = new Image[3];
    /// <summary>
    /// Keeps the three demonstrations ticking while the sheet is up. One repeating
    /// call drives all three so they stay in step with each other.
    /// </summary>
    private void _0x200525d3()
    {
        DOTween.Kill(this);
        this._0xa8376c7f = 0;
        this._0x0360f19c = 12;
        this._0x5bbbe5e1 = 0;
        DOVirtual.DelayedCall(1.1f, () => this._0x931c1761()).SetLoops(-1).SetId(this);
    }

    public void _0xc0850c4c()
    {
        if (this._0xf8326def == null)
            return;
        DOTween.Kill(this);
        this._0xf8326def.gameObject.SetActive(false);
    }

    [SerializeField]
    private Sprite _crystalSprite;
    private int _0x0360f19c = 12;
    [SerializeField]
    private Sprite _plateSprite;
    private RectTransform _0xf8326def;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _tapSprite;
    private Image _0x6f19ac7e;
    private void _0x931c1761()
    {
        if (this._0xf8326def == null || !this._0xf8326def.gameObject.activeInHierarchy)
            return;
        this._0xa8376c7f = (this._0xa8376c7f + 1) % _0x0f96bb7d.Axes;
        if (this._0xef310db1 != null)
            this._0xef310db1.DOLocalRotate(new Vector3(0f, 0f, _0x0f96bb7d.MirrorSpin(this._0xa8376c7f)), 0.3f, RotateMode.FastBeyond360).SetEase(Ease.OutBack);
        this._0x0360f19c--;
        if (this._0x0360f19c < 9)
            this._0x0360f19c = 12;
        if (this._0xf999bec2 != null)
        {
            this._0xf999bec2.text = _0x97e8cd6e._0x93c58dae(new byte[6] { 101, 103, 126, 109, 123, 8 }, 40) + this._0x0360f19c.ToString();
            Transform _0x86fa381e = this._0xf999bec2.transform;
            _0x86fa381e.localScale = Vector3.one;
            _0x86fa381e.DOPunchScale(Vector3.one * 0.12f, 0.24f, 1, 0.5f);
        }

        this._0x5bbbe5e1 = (this._0x5bbbe5e1 + 1) % (this._0x14b2c541.Length + 2);
        for (int _0x52ffe956 = 0; _0x52ffe956 < this._0x14b2c541.Length; _0x52ffe956++)
        {
            if (this._0x14b2c541[_0x52ffe956] == null)
                continue;
            bool _0xe2c26172 = _0x52ffe956 < this._0x5bbbe5e1;
            this._0x14b2c541[_0x52ffe956].sprite = _0xe2c26172 ? this._nodeLitSprite : this._nodeSprite;
            this._0x14b2c541[_0x52ffe956].color = _0xe2c26172 ? _0xc95d1bd8.BeamPale : _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.9f);
        }

        if (this._0x6f19ac7e != null)
            this._0x6f19ac7e.color = this._0x5bbbe5e1 > this._0x14b2c541.Length ? _0xc95d1bd8.Gold : _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Gold, 0.3f);
    }

    private int _0x5bbbe5e1;
    [SerializeField]
    private Sprite _nodeLitSprite;
}

internal static class _0x97e8cd6e
{
    internal static string _0x93c58dae(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}