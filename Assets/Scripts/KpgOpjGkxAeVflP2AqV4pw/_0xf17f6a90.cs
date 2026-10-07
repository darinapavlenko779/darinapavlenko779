using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// The world-space lattice: the glow plate under it, twenty hex tiles on top, and
/// the hint ring that drifts to whichever mirror is worth a look.
///
/// EVERY size here is derived from the camera (C.0). A pointy-top honeycomb with
/// odd rows pushed half a cell right needs COLS+0.5 cell widths across, and its
/// rows sit three quarters of a hex height apart; the cell width is whichever of
/// the two fits, so the board never reaches past the viewport on either axis.
/// </summary>
public sealed class _0xf17f6a90 : MonoBehaviour
{
    private const float WidthShare = 0.86f;
    private float _0xba22ddaf;
    public _0xa220087a _0xa33f3d6b(int _0x5a72f272)
    {
        for (int _0xc6833ae9 = 0; _0xc6833ae9 < this._0xbe06b7a7.Count; _0xc6833ae9++)
            if (this._0xbe06b7a7[_0xc6833ae9] != null && this._0xbe06b7a7[_0xc6833ae9]._0x9d969da4 == _0x5a72f272)
                return this._0xbe06b7a7[_0xc6833ae9];
        return null;
    }

    public float _0xc767a88c
    {
        get
        {
            return this._0x951cc975;
        }
    }

    private float _0x951cc975;
    private float _0x8b85ac7b;
    [SerializeField]
    private Sprite _checkpointLitSprite;
    public void _0x97945fd3()
    {
        Camera _0x762a31e0 = this._0x95f712fa;
        if (_0x762a31e0 == null)
            return;
        float _0x2916dd72 = _0x762a31e0.orthographicSize;
        float _0x59246a1c = _0x2916dd72 * _0x762a31e0.aspect;
        float _0xbf08bd42 = 2f * _0x59246a1c * WidthShare / (_0x0f96bb7d.Cols + 0.5f);
        // boardHeight = hexH + (ROWS-1)*0.75*hexH and hexH = hexW * 2/sqrt(3)
        float _0x43a4362a = (1f + (_0x0f96bb7d.Rows - 1) * 0.75f) * 2f / Mathf.Sqrt(3f);
        float _0x1ae553e5 = 2f * _0x2916dd72 * HeightShare / _0x43a4362a;
        this._0x951cc975 = Mathf.Min(_0xbf08bd42, _0x1ae553e5);
        this._0xffd244ad = this._0x951cc975 * 2f / Mathf.Sqrt(3f);
        this._0x2a0046b9 = this._0xffd244ad * 0.75f;
        float _0xa0967467 = this._0x951cc975 * (_0x0f96bb7d.Cols + 0.5f);
        float _0xd09ebdfe = this._0xffd244ad + (_0x0f96bb7d.Rows - 1) * this._0x2a0046b9;
        this._0xba22ddaf = -_0xa0967467 * 0.5f;
        this._0x8b85ac7b = CentreY + _0xd09ebdfe * 0.5f;
        this._0x7e077453 = true;
    }

    public void _0x89c80c6b(Camera _0x24154e01)
    {
        this._0x95f712fa = _0x24154e01;
    }

    [SerializeField]
    private GameObject _glowPrefab;
    [SerializeField]
    private Sprite _crystalSprite;
    // ------------------------------------------------------------------- reacting
    public void _0x5d32f54c(int _0xf3cfae45, _0xc136060f _0x519280a0, float _0x661a610a)
    {
        _0xa220087a _0xdd5ab7cc = this._0xa33f3d6b(_0xf3cfae45);
        if (_0xdd5ab7cc == null || _0x519280a0 == null)
            return;
        _0xdd5ab7cc._0xbc20628a(_0x0f96bb7d.MirrorSpin(_0x519280a0.State[_0xf3cfae45]), _0x661a610a);
    }

    public void _0x3643055e()
    {
        if (this._0xa585eccf == null)
            return;
        DOTween.Kill(this._0xa585eccf);
        this._0xa585eccf.localScale = Vector3.one;
        this._0xa585eccf.gameObject.SetActive(false);
    }

    private bool _0x7e077453;
    [SerializeField]
    private Sprite _mirrorSprite;
    // ------------------------------------------------------------------ building
    public void _0xc7bad6c8(_0xc136060f _0x50e492ee)
    {
        this._0x97945fd3();
        this._0x8922e06d();
        if (_0x50e492ee == null || this._boardRoot == null)
            return;
        float _0xd5e1a145 = this._0x951cc975 * (_0x0f96bb7d.Cols + 0.5f);
        float _0xbdef4eca = this._0xffd244ad + (_0x0f96bb7d.Rows - 1) * this._0x2a0046b9;
        // The plate is created FIRST so every tile is a later sibling and draws on
        // top of it rather than under it (C.13).
        if (this._glowPrefab != null)
        {
            GameObject _0x04c6e579 = Instantiate(this._glowPrefab, this._boardRoot);
            _0x04c6e579.transform.position = new Vector3(0f, CentreY, 0f);
            _0x04c6e579.transform.localScale = Vector3.one;
            this._0xe335736d = _0x04c6e579.GetComponent<SpriteRenderer>();
            if (this._0xe335736d != null)
            {
                this._0xe335736d.size = new Vector2(_0xd5e1a145 + this._0x951cc975 * 0.34f, _0xbdef4eca + this._0x951cc975 * 0.34f);
                this._0xe335736d.color = _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.34f);
            }
        }

        float _0x7868dc33 = this._0x951cc975 * TileShare;
        for (int _0x35f86585 = 0; _0x35f86585 < _0x0f96bb7d.Cells; _0x35f86585++)
        {
            if (this._tilePrefab == null)
                break;
            GameObject _0xef9a27d1 = Instantiate(this._tilePrefab, this._boardRoot);
            _0xa220087a _0xdedd0192 = _0xef9a27d1.GetComponent<_0xa220087a>();
            if (_0xdedd0192 == null)
                continue;
            _0xdedd0192._0xbb8f1d85(_0x35f86585, this._0xd8b4ec99(_0x35f86585), _0x7868dc33);
            this._0x56a2b6a1(_0xdedd0192, _0x50e492ee, _0x35f86585, false);
            this._0xbe06b7a7.Add(_0xdedd0192);
            Transform _0x8d4b4519 = _0xef9a27d1.transform;
            Vector3 _0x43588ee5 = _0x8d4b4519.position;
            _0x8d4b4519.position = _0x43588ee5 + new Vector3(0f, this._0x951cc975 * 0.9f, 0f);
            _0x8d4b4519.DOMove(_0x43588ee5, 0.34f).SetDelay(0.022f * _0x35f86585).SetEase(Ease.OutBack);
        }

        if (this._hintPrefab != null && this._0xa585eccf == null)
        {
            GameObject _0x5127660a = Instantiate(this._hintPrefab, this._boardRoot);
            SpriteRenderer _0x3f3b8dec = _0x5127660a.GetComponent<SpriteRenderer>();
            if (_0x3f3b8dec != null)
            {
                _0x3f3b8dec.size = new Vector2(_0x7868dc33 * 1.12f, _0x7868dc33 * 1.12f);
                _0x3f3b8dec.color = _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Beam, 0.85f);
            }

            this._0xa585eccf = _0x5127660a.transform;
            _0x5127660a.SetActive(false);
        }
    }

    public void _0x2b5a2bcd(float _0x27656eb1, float _0x378bcfc3)
    {
        for (int _0x90b43b29 = 0; _0x90b43b29 < this._0xbe06b7a7.Count; _0x90b43b29++)
            if (this._0xbe06b7a7[_0x90b43b29] != null)
                this._0xbe06b7a7[_0x90b43b29]._0x4c9cdcf5(_0x27656eb1, _0x378bcfc3);
    }

    /// <summary>Repaints every checkpoint and punches the ones that just came alive.</summary>
    public void _0xcca51348(_0xc136060f _0xf6e2c1cd, _0xa7f280da _0x27a905ac)
    {
        if (_0xf6e2c1cd == null || _0x27a905ac == null)
            return;
        for (int _0x8078b484 = 0; _0x8078b484 < _0xf6e2c1cd.Checkpoints.Count; _0x8078b484++)
        {
            int _0xaf0a03c0 = _0xf6e2c1cd.Checkpoints[_0x8078b484];
            _0xa220087a _0xcb0e78c6 = this._0xa33f3d6b(_0xaf0a03c0);
            if (_0xcb0e78c6 == null)
                continue;
            bool _0xa1a03001 = _0x27a905ac._0x006dcb38(_0xaf0a03c0);
            _0xcb0e78c6._0xbdd36b04(_0xa1a03001 ? this._checkpointLitSprite : this._checkpointSprite, _0xa1a03001 ? _0xc95d1bd8.BeamPale : _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.95f));
            if (_0xa1a03001)
                _0xcb0e78c6._0x90e2c406(0.16f);
        }
    }

    public void _0x8922e06d()
    {
        for (int _0x7426c93f = 0; _0x7426c93f < this._0xbe06b7a7.Count; _0x7426c93f++)
            if (this._0xbe06b7a7[_0x7426c93f] != null)
                Destroy(this._0xbe06b7a7[_0x7426c93f].gameObject);
        this._0xbe06b7a7.Clear();
        if (this._0xe335736d != null)
        {
            Destroy(this._0xe335736d.gameObject);
            this._0xe335736d = null;
        }

        if (this._0xa585eccf != null)
        {
            Destroy(this._0xa585eccf.gameObject);
            this._0xa585eccf = null;
        }
    }

    public void _0x89926b41()
    {
        if (this._boardRoot == null)
            return;
        Transform _0xd5dd0d68 = this._boardRoot;
        DOTween.Kill(_0xd5dd0d68);
        _0xd5dd0d68.localPosition = Vector3.zero;
        _0xd5dd0d68.DOShakePosition(0.32f, this._0x951cc975 * 0.05f, 20, 90f, false, true).OnComplete(() => _0xd5dd0d68.localPosition = Vector3.zero);
    }

    private float _0xffd244ad;
    private readonly List<_0xa220087a> _0xbe06b7a7 = new List<_0xa220087a>(_0x0f96bb7d.Cells);
    [SerializeField]
    private Sprite _blockerSprite;
    public void _0xd0e3e1d4(int _0xa6a5ab0f)
    {
        _0xa220087a _0xee62d4f7 = this._0xa33f3d6b(_0xa6a5ab0f);
        if (_0xee62d4f7 != null)
            _0xee62d4f7._0xabb8739c(this._0x951cc975 * 0.06f, _0xc95d1bd8.Rose);
    }

    [SerializeField]
    private Sprite _emitterSprite;
    private const float HeightShare = 0.46f;
    private Transform _0xa585eccf;
    private const float CentreY = -0.35f;
    [SerializeField]
    private GameObject _tilePrefab;
    private float _0x2a0046b9;
    [SerializeField]
    private Sprite _inertSprite;
    [SerializeField]
    private Sprite _checkpointSprite;
    private Camera _0x95f712fa;
    private SpriteRenderer _0xe335736d;
    public Vector3 _0xd8b4ec99(int _0x01e67611)
    {
        if (!this._0x7e077453)
            this._0x97945fd3();
        int _0xb485f85a = _0x0f96bb7d.ColumnOf(_0x01e67611);
        int _0x6efe6d9c = _0x0f96bb7d.RowOf(_0x01e67611);
        float _0x59061217 = (_0x6efe6d9c & 1) == 1 ? this._0x951cc975 * 0.5f : 0f;
        float _0x09ff0a91 = this._0xba22ddaf + this._0x951cc975 * (_0xb485f85a + 0.5f) + _0x59061217;
        float _0x91c0f380 = this._0x8b85ac7b - this._0xffd244ad * 0.5f - _0x6efe6d9c * this._0x2a0046b9;
        return new Vector3(_0x09ff0a91, _0x91c0f380, 0f);
    }

    private void _0x56a2b6a1(_0xa220087a _0x89f9bf2a, _0xc136060f _0x92398c6b, int _0x732fb0b0, bool _0x03cce548)
    {
        int _0x0b97118e = _0x92398c6b.Kind[_0x732fb0b0];
        _0x89f9bf2a._0x5b79e662(0f);
        if (_0x0b97118e == _0xc136060f.KindMirror)
        {
            _0x89f9bf2a._0xe95faeca(_0x0b97118e, this._mirrorSprite, _0xc95d1bd8.Cream, null, _0xc95d1bd8.Cream);
            _0x89f9bf2a._0x5b79e662(_0x0f96bb7d.MirrorSpin(_0x92398c6b.State[_0x732fb0b0]));
            return;
        }

        if (_0x0b97118e == _0xc136060f.KindBlocker)
        {
            _0x89f9bf2a._0xe95faeca(_0x0b97118e, this._blockerSprite, _0xc95d1bd8.Rose, null, _0xc95d1bd8.Rose);
            return;
        }

        if (_0x0b97118e == _0xc136060f.KindCheckpoint)
        {
            Sprite _0x63bf5dd3 = _0x03cce548 ? this._checkpointLitSprite : this._checkpointSprite;
            Color _0x9841d4f1 = _0x03cce548 ? _0xc95d1bd8.BeamPale : _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.95f);
            _0x89f9bf2a._0xe95faeca(_0x0b97118e, this._inertSprite, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Surface, 0.95f), _0x63bf5dd3, _0x9841d4f1);
            return;
        }

        if (_0x0b97118e == _0xc136060f.KindCrystal)
        {
            _0x89f9bf2a._0xe95faeca(_0x0b97118e, this._inertSprite, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Surface, 0.95f), this._crystalSprite, _0xc95d1bd8.Gold);
            return;
        }

        if (_0x0b97118e == _0xc136060f.KindEmitter)
        {
            _0x89f9bf2a._0xe95faeca(_0x0b97118e, this._inertSprite, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Surface, 0.95f), this._emitterSprite, _0xc95d1bd8.Beam);
            return;
        }

        _0x89f9bf2a._0xe95faeca(_0x0b97118e, this._inertSprite, _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Night, 0.92f), null, _0xc95d1bd8.Cream);
    }

    /// <summary>The mirror furthest from where the solution wants it - the most useful nudge.</summary>
    public static int MostWantedMirror(_0xc136060f _0x9bbba141)
    {
        if (_0x9bbba141 == null)
            return -1;
        int _0xf716c353 = -1;
        int _0x5ad1fdfa = 0;
        for (int _0x6aa60833 = 0; _0x6aa60833 < _0x0f96bb7d.Cells; _0x6aa60833++)
        {
            if (_0x9bbba141.Solved[_0x6aa60833] < 0)
                continue;
            int _0xd724896f = _0x0f96bb7d.TapsBetween(_0x9bbba141.State[_0x6aa60833], _0x9bbba141.Solved[_0x6aa60833]);
            if (_0xd724896f <= _0x5ad1fdfa)
                continue;
            _0x5ad1fdfa = _0xd724896f;
            _0xf716c353 = _0x6aa60833;
        }

        return _0xf716c353;
    }

    /// <summary>
    /// Nearest cell to a world point, by measured distance rather than by collider:
    /// twenty candidates is cheaper than a physics query and owes nothing to names.
    /// </summary>
    public bool _0xeb7a75cc(Vector3 _0x2aa80492, out int _0xebdf2036)
    {
        _0xebdf2036 = -1;
        if (!this._0x7e077453 || this._0x951cc975 <= 0f)
            return false;
        float _0xe7dfc26b = this._0x951cc975 * 0.56f;
        for (int _0xba3051a4 = 0; _0xba3051a4 < _0x0f96bb7d.Cells; _0xba3051a4++)
        {
            Vector3 _0x6e7f9bbd = this._0xd8b4ec99(_0xba3051a4);
            float _0x23edd276 = _0x2aa80492.x - _0x6e7f9bbd.x;
            float _0x1b7917a9 = _0x2aa80492.y - _0x6e7f9bbd.y;
            float _0xd87fb376 = Mathf.Sqrt(_0x23edd276 * _0x23edd276 + _0x1b7917a9 * _0x1b7917a9);
            if (_0xd87fb376 >= _0xe7dfc26b)
                continue;
            _0xe7dfc26b = _0xd87fb376;
            _0xebdf2036 = _0xba3051a4;
        }

        return _0xebdf2036 >= 0;
    }

    [SerializeField]
    private GameObject _hintPrefab;
    private const float TileShare = 0.96f;
    [SerializeField]
    private Transform _boardRoot;
    // ----------------------------------------------------------------- hint ring
    public void _0xdab159b7(int _0x65a8d84a)
    {
        if (this._0xa585eccf == null || _0x65a8d84a < 0)
            return;
        this._0xa585eccf.gameObject.SetActive(true);
        this._0xa585eccf.position = this._0xd8b4ec99(_0x65a8d84a);
        this._0xa585eccf.localScale = Vector3.one;
        DOTween.Kill(this._0xa585eccf);
        this._0xa585eccf.DOScale(1.12f, 0.9f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    public void _0xb77b6574(_0xc136060f _0x8317ab88)
    {
        if (_0x8317ab88 == null)
            return;
        _0xa220087a _0x537ff7f9 = this._0xa33f3d6b(_0x8317ab88.CrystalCell);
        if (_0x537ff7f9 != null)
            _0x537ff7f9._0x90e2c406(0.3f);
        if (this._0xe335736d == null)
            return;
        SpriteRenderer _0xda8431a4 = this._0xe335736d;
        DOTween.Kill(_0xda8431a4);
        _0xda8431a4.color = _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Gold, 0.55f);
        _0xda8431a4.DOColor(_0xc95d1bd8.WithAlpha(_0xc95d1bd8.Violet, 0.34f), 0.9f);
    }
}