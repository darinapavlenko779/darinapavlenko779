using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>
/// Runs a node: builds the screen into the template's panel body, routes taps to the
/// lattice, spends moves, and raises the three result cards by their SETTINGS index.
///
/// Nothing here can end a run on its own. There is no timer, no draining bar and no
/// automatic failure: moves are spent only by a deliberate tap on a mirror, so an
/// untouched board stays on screen for as long as the capture window needs (C.5).
/// </summary>
public sealed class _0xe98cdb6e : MonoBehaviour
{
    private _0xc136060f _0xad74fb8e;
    [SerializeField]
    private Sprite _pipSprite;
    private void _0x54545d7e()
    {
        this._0xc9b26a27 = _0x94c2c64e.Settled;
        this._board._0xb77b6574(this._0xad74fb8e);
        this._hud._0x80e94f2a(_0x1c708f85._0xedb81358(new byte[14] { 168, 185, 178, 184, 191, 170, 167, 203, 164, 165, 167, 162, 165, 174 }, 235), _0xc95d1bd8.BeamPale);
        int _0x2c490308 = _0x194db6fe.StarsEarned(this._0x798b44b9, this._0xad74fb8e.SolutionTaps);
        this._0xce68e38e._0xe048fe34(this._0x03436fb6, _0x2c490308);
        int _0xdb9192af = this._0x03436fb6;
        int _0x53990c31 = this._0x798b44b9;
        int _0x462927f7 = this._0xad74fb8e.MoveBudget;
        DOVirtual.DelayedCall(WinHold, () => this._0x18e1031b(_0xdb9192af, _0x2c490308, _0x53990c31, _0x462927f7)).SetId(this);
    }

    private const float IdleHintSeconds = 6f;
    private int _0xb65e1019;
    [SerializeField]
    private Sprite _blockerSprite;
    private void _0xe803e823()
    {
        if (_0x940c8b68.Instance == null)
            return;
        if (_0x7b505880.Instance != null)
            _0x7b505880.Instance._0xa077288f();
        _0x940c8b68.Instance.LoadSceneByIndex(_0x3beca35c._0xc6939daa.SCENE_0);
    }

    private enum _0x94c2c64e
    {
        Building,
        Idling,
        Turning,
        Held,
        Settled,
    }

    [SerializeField]
    private Sprite _starSprite;
    private readonly _0xa7f280da _0xe5e93aa1 = new _0xa7f280da();
    [SerializeField]
    private TMP_FontAsset _font;
    private void _0xcfb64b28()
    {
        if (this == null || this._0xc9b26a27 != _0x94c2c64e.Turning || this._0xad74fb8e == null)
            return;
        this._0xe5e93aa1._0xc84e8214(this._0xad74fb8e);
        if (this._beams != null)
            this._beams._0xa0e22eb1(this._board, this._0xad74fb8e, this._0xe5e93aa1, true);
        this._board._0xcca51348(this._0xad74fb8e, this._0xe5e93aa1);
        this._hud._0xd2e5109d(this._0xad74fb8e.Checkpoints.Count, this._0xe5e93aa1.LitCheckpoints.Count);
        if (this._0xe5e93aa1._0x40eeaf7b(this._0xad74fb8e))
        {
            this._0x54545d7e();
            return;
        }

        if (this._0xe5e93aa1.HitBlocker)
            this._0x468077f8();
        if (this._0xe810b34b <= 0)
        {
            this._0xb830a636();
            return;
        }

        this._0xc9b26a27 = _0x94c2c64e.Idling;
        this._0xf3c16692 = 0f;
    }

    private int _0xe810b34b;
    private const int OverloadPenalty = 2;
    private const float RetraceSeconds = 0.16f;
    [SerializeField]
    private _0x79aea613 _hud;
    [SerializeField]
    private _0xcc1f5425 _pops;
    private int _0x798b44b9;
    private readonly _0xabb6ba5f _0xfcc148d9 = new _0xabb6ba5f();
    private void _0x18e1031b(int _0x09c6879e, int _0x3f8cd760, int _0x3ef4a1f0, int _0x5babf38c)
    {
        if (this == null || this._pops == null)
            return;
        this._pops._0x6cc853ac(_0x09c6879e, _0x3f8cd760, _0x3ef4a1f0, _0x5babf38c);
    }

    private bool _0xf947b0e5;
    private _0x94c2c64e _0xc9b26a27 = _0x94c2c64e.Building;
    // ----------------------------------------------------------------- navigation
    private void _0x4ad80fff()
    {
        if (this._0xc9b26a27 == _0x94c2c64e.Settled || this._pops == null)
            return;
        this._0xc9b26a27 = _0x94c2c64e.Held;
        this._pops._0x378a70c2(this._0xe810b34b);
    }

    private Camera _0xa1fffeca;
    // ------------------------------------------------------------------- one node
    private void _0xfa948eb1()
    {
        this._0x03436fb6 = this._0xce68e38e._0x9bc90056;
        int _0xa27beb9c = this._0xce68e38e._0xd6f9a310(this._0x03436fb6);
        this._0xce68e38e._0x2f4592ef(this._0x03436fb6);
        this._0xad74fb8e = this._0xfcc148d9._0x31647424(this._0x03436fb6, _0xa27beb9c);
        this._0xe810b34b = this._0xad74fb8e.MoveBudget;
        this._0x798b44b9 = 0;
        this._0xb65e1019 = 0;
        this._0x59d51d15 = false;
        this._0xf3c16692 = 0f;
        this._0xf947b0e5 = false;
        this._board._0xc7bad6c8(this._0xad74fb8e);
        this._0xe5e93aa1._0xc84e8214(this._0xad74fb8e);
        if (this._beams != null)
            this._beams._0xa0e22eb1(this._board, this._0xad74fb8e, this._0xe5e93aa1, false);
        this._hud._0xf54c096e(this._0x03436fb6);
        this._hud._0xaedbba74(this._0xe810b34b, false);
        this._hud._0xd2e5109d(this._0xad74fb8e.Checkpoints.Count, this._0xe5e93aa1.LitCheckpoints.Count);
        this._board._0xcca51348(this._0xad74fb8e, this._0xe5e93aa1);
        this._0xc9b26a27 = _0x94c2c64e.Idling;
    }

    private void _0x9fae219b()
    {
        if (_0x940c8b68.Instance == null)
            return;
        if (_0x7b505880.Instance != null)
            _0x7b505880.Instance._0xa077288f();
        _0x940c8b68.Instance._0x216c67a7();
    }

    /// <summary>
    /// The idle nudge. It is purely a picture: it costs no move, changes no state and
    /// cannot shorten a run, so the board still survives an untouched capture window.
    /// </summary>
    private void Update()
    {
        if (this._0xc9b26a27 != _0x94c2c64e.Idling || this._board == null || this._0xad74fb8e == null)
            return;
        this._0xf3c16692 += Time.deltaTime;
        if (this._0xf947b0e5 || this._0xf3c16692 < IdleHintSeconds)
            return;
        int _0x9afe8e84 = _0xf17f6a90.MostWantedMirror(this._0xad74fb8e);
        if (_0x9afe8e84 < 0)
            return;
        this._board._0xdab159b7(_0x9afe8e84);
        this._0xf947b0e5 = true;
    }

    [SerializeField]
    private Sprite _closeIcon;
    [SerializeField]
    private _0xb5bd9219 _beams;
    private const float WinHold = 0.95f;
    private void _0x2092458d(bool _0x756d6688, int _0x1d6ccef5, int _0x0c348f51, int _0xe2d18f05, int _0x76233b97)
    {
        if (this == null || this._pops == null)
            return;
        this._pops._0x69b0c373(_0x756d6688, _0x1d6ccef5, _0x0c348f51, _0xe2d18f05, _0x76233b97);
    }

    // ----------------------------------------------------------------- a player tap
    private void _0xe6eb7ad4(Vector3 _0x1d246f31)
    {
        if (this._0xc9b26a27 != _0x94c2c64e.Idling || this._board == null || this._0xad74fb8e == null)
            return;
        int _0xf94d3d1b;
        if (!this._board._0xeb7a75cc(_0x1d246f31, out _0xf94d3d1b))
            return;
        this._0x2c3a9b7a();
        if (!this._0xad74fb8e._0x6534485a(_0xf94d3d1b))
        {
            // Not a mirror, so not a move - but never a silent tap (C.7).
            this._board._0xd0e3e1d4(_0xf94d3d1b);
            this._hud._0x80e94f2a(_0x1c708f85._0xedb81358(new byte[22] { 113, 112, 114, 103, 30, 115, 119, 108, 108, 113, 108, 30, 118, 123, 102, 123, 109, 30, 106, 107, 108, 112 }, 62), _0xc95d1bd8.Rose);
            return;
        }

        this._0xad74fb8e._0xe2e97a79(_0xf94d3d1b);
        this._board._0x5d32f54c(_0xf94d3d1b, this._0xad74fb8e, TurnSeconds);
        this._0xe810b34b--;
        this._0x798b44b9++;
        this._hud._0xaedbba74(this._0xe810b34b, true);
        this._0xc9b26a27 = _0x94c2c64e.Turning;
        DOVirtual.DelayedCall(TurnSeconds + RetraceSeconds, () => this._0xcfb64b28()).SetId(this);
    }

    [SerializeField]
    private _0xf17f6a90 _board;
    private readonly _0x194db6fe _0xce68e38e = new _0x194db6fe();
    private const float TurnSeconds = 0.2f;
    private void _0x7bdf56bd()
    {
        int _0xc598a7a8 = this._0x03436fb6 + 1;
        if (_0xc598a7a8 >= _0xabb6ba5f.LevelCount)
            _0xc598a7a8 = 0;
        this._0xce68e38e._0x9bc90056 = _0xc598a7a8;
        this._0x9fae219b();
    }

    [SerializeField]
    private Sprite _backIcon;
    private void _0x2c3a9b7a()
    {
        this._0xf3c16692 = 0f;
        if (!this._0xf947b0e5)
            return;
        this._0xf947b0e5 = false;
        if (this._board != null)
            this._board._0x3643055e();
    }

    private const float LoseHold = 0.55f;
    private void _0xb830a636()
    {
        this._0xc9b26a27 = _0x94c2c64e.Settled;
        if (this._beams != null)
            this._beams._0x7d84387b(0.4f);
        this._board._0x2b5a2bcd(0.35f, 0.4f);
        bool _0x6ffe8e33 = this._0x59d51d15;
        int _0xb68ee7a8 = this._0xe5e93aa1.LitCheckpoints.Count;
        int _0x45a6787a = this._0xad74fb8e.Checkpoints.Count;
        int _0x06a0d006 = this._0x798b44b9;
        int _0x4385cc12 = this._0xad74fb8e.MoveBudget;
        DOVirtual.DelayedCall(LoseHold, () => this._0x2092458d(_0x6ffe8e33, _0xb68ee7a8, _0x45a6787a, _0x06a0d006, _0x4385cc12)).SetId(this);
    }

    private float _0xf3c16692;
    private void OnDestroy()
    {
        DOTween.Kill(this);
    }

    private int _0x03436fb6;
    private bool _0x59d51d15;
    private void Start()
    {
        if (this._hud == null || this._board == null)
            return;
        Transform _0x8353c316 = _0x6b65542d.PanelBody(_0x3beca35c._0x7817e4f1.DEFAULT);
        if (_0x8353c316 == null)
            return;
        // Rule H, option 2: the template's own top bar and counters live in this body.
        // Switching every child off leaves one consistent control set on screen rather
        // than template buttons sitting beside generated ones.
        _0x6b65542d.ClearChildren(_0x8353c316);
        this._hud._0x94050be0(_0x8353c316, this._0xa1fffeca, this._font, this._plateSprite, this._backIcon, this._pauseIcon, this._pipSprite, () => this._0xe803e823(), () => this._0x4ad80fff(), (Vector3 _0x2dc4f910) => this._0xe6eb7ad4(_0x2dc4f910));
        if (this._pops != null)
            this._pops._0x682bb0ca(this._font, this._plateSprite, this._closeIcon, this._starSprite, this._blockerSprite, this._pauseIcon, () => this._0x7bdf56bd(), () => this._0x9fae219b(), () => this._0xe803e823(), () => this._0xbdc2cdf2(), () => this._0x9fae219b());
        _0x6b65542d.BlankTemplateTutorials();
        this._0xfa948eb1();
    }

    [SerializeField]
    private Sprite _pauseIcon;
    [SerializeField]
    private Sprite _plateSprite;
    private void _0xbdc2cdf2()
    {
        if (this._pops != null)
            this._pops._0x8b3e5483();
        if (this._0xc9b26a27 == _0x94c2c64e.Held)
        {
            this._0xc9b26a27 = _0x94c2c64e.Idling;
            this._0xf3c16692 = 0f;
        }
    }

    /// <summary>
    /// A blocker swallowing the beam burns two further moves. It is the real reason a
    /// run is lost, but it never ends the run on the spot: one unlucky first tap must
    /// not decide the node (and must not empty the capture album of gameplay).
    /// </summary>
    private void _0x468077f8()
    {
        this._0xb65e1019++;
        this._0x59d51d15 = true;
        this._0xe810b34b = Mathf.Max(0, this._0xe810b34b - OverloadPenalty);
        this._hud._0xaedbba74(this._0xe810b34b, true);
        this._hud._0xe0706663();
        this._hud._0x80e94f2a(_0x1c708f85._0xedb81358(new byte[18] { 106, 115, 96, 119, 105, 106, 100, 97, 5, 5, 8, 23, 5, 104, 106, 115, 96, 118 }, 37), _0xc95d1bd8.Rose);
        this._board._0x89926b41();
    }

    private void Awake()
    {
        this._0xa1fffeca = Camera.main;
        if (this._board != null)
            this._board._0x89c80c6b(this._0xa1fffeca);
    }
}

internal static class _0x1c708f85
{
    internal static string _0xedb81358(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}