using DG.Tweening;
using UnityEngine;

/// <summary>
/// One cell of the lattice: the hex tile itself and the glyph that says what lives
/// on it.
///
/// Size travels through SpriteRenderer.size (both renderers are Sliced), so the
/// drawn width is authoritative and a 512 px source can never render five world
/// units wide. transform.localScale stays at one and is only ever borrowed by a
/// punch, which puts it back.
/// </summary>
public sealed class _0xa220087a : MonoBehaviour
{
    public void _0xe95faeca(int _0x9787477c, Sprite _0x1cc20299, Color _0xfcb17b96, Sprite _0x0161c50a, Color _0x50fce7b0)
    {
        this._0x32ab0f1a = _0x9787477c;
        if (this._body != null)
        {
            this._body.sprite = _0x1cc20299;
            this._body.color = _0xfcb17b96;
        }

        if (this._glyph == null)
            return;
        this._glyph.sprite = _0x0161c50a;
        this._glyph.color = _0x50fce7b0;
        this._glyph.enabled = _0x0161c50a != null;
    }

    private int _0x2de7e03e;
    /// <summary>Mirrors show their angle by turning the tile; everything else stays upright.</summary>
    public void _0x5b79e662(float _0xb40370af)
    {
        this.transform.localRotation = Quaternion.Euler(0f, 0f, _0xb40370af);
    }

    public int _0x9d969da4
    {
        get
        {
            return this._0x2de7e03e;
        }
    }

    [SerializeField]
    private SpriteRenderer _glyph;
    private int _0x32ab0f1a;
    /// <summary>The acknowledgement for a tap that cannot do anything (C.7).</summary>
    public void _0xabb8739c(float _0xe65524bb, Color _0xd4dd2fc4)
    {
        Transform _0x5f1f6064 = this.transform;
        Vector3 _0x17ad8185 = _0x5f1f6064.position;
        DOTween.Kill(_0x5f1f6064);
        _0x5f1f6064.DOShakePosition(0.22f, _0xe65524bb, 18, 90f, false, true).OnComplete(() => _0x5f1f6064.position = _0x17ad8185);
        if (this._body == null)
            return;
        SpriteRenderer _0x3410554d = this._body;
        Color _0xf4c4f695 = _0x3410554d.color;
        DOTween.Kill(_0x3410554d);
        _0x3410554d.color = _0xd4dd2fc4;
        _0x3410554d.DOColor(_0xf4c4f695, 0.26f);
    }

    [SerializeField]
    private SpriteRenderer _body;
    public void _0xbc20628a(float _0xd1db09f6, float _0xd374e00c)
    {
        Transform _0x9161d3a1 = this.transform;
        DOTween.Kill(_0x9161d3a1);
        _0x9161d3a1.DOLocalRotate(new Vector3(0f, 0f, _0xd1db09f6), _0xd374e00c, RotateMode.FastBeyond360).SetEase(Ease.OutBack);
    }

    public void _0xbdd36b04(Sprite _0x9597c4c7, Color _0x8b1caf95)
    {
        if (this._glyph == null)
            return;
        this._glyph.sprite = _0x9597c4c7;
        this._glyph.color = _0x8b1caf95;
        this._glyph.enabled = _0x9597c4c7 != null;
    }

    public int _0x77ddc6c0
    {
        get
        {
            return this._0x32ab0f1a;
        }
    }

    public void _0x4c9cdcf5(float _0x7ff1d039, float _0xd5031952)
    {
        if (this._body != null)
            this._body.DOFade(_0x7ff1d039, _0xd5031952);
        if (this._glyph != null && this._glyph.enabled)
            this._glyph.DOFade(_0x7ff1d039, _0xd5031952);
    }

    public void _0x90e2c406(float _0xabe436e7)
    {
        Transform _0x5247858a = this.transform;
        _0x5247858a.localScale = Vector3.one;
        _0x5247858a.DOPunchScale(Vector3.one * _0xabe436e7, 0.26f, 1, 0.5f);
    }

    public void _0xbb8f1d85(int _0x5af918b0, Vector3 _0xd71dab55, float _0xd9065847)
    {
        this._0x2de7e03e = _0x5af918b0;
        this.transform.position = _0xd71dab55;
        this.transform.localScale = Vector3.one;
        if (this._body != null)
            this._body.size = new Vector2(_0xd9065847, _0xd9065847);
        if (this._glyph != null)
            this._glyph.size = new Vector2(_0xd9065847 * 0.52f, _0xd9065847 * 0.52f);
    }
}