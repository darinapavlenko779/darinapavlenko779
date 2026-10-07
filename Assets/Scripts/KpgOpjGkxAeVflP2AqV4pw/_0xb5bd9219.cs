using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// Draws the light. One sliced bar per hop, a bead at every corner, and a spark that
/// runs the whole route so the picture reads as moving light rather than a diagram.
///
/// Rebuilding is cheap (a route is at most sixty-four hops on a twenty-cell board),
/// so every re-trace redraws from scratch and then flashes, which is what makes a
/// re-route legible on a still screenshot.
/// </summary>
public sealed class _0xb5bd9219 : MonoBehaviour
{
    [SerializeField]
    private GameObject _beadPrefab;
    private void OnDestroy()
    {
        DOTween.Kill(this);
    }

    private readonly List<SpriteRenderer> _0xea15f5b6 = new List<SpriteRenderer>(48);
    [SerializeField]
    private GameObject _sparkPrefab;
    public void _0x7d84387b(float _0x824c4120)
    {
        DOTween.Kill(this);
        if (this._0x7f1a2b1b != null)
            this._0x7f1a2b1b.gameObject.SetActive(false);
        for (int _0x8fd40744 = 0; _0x8fd40744 < this._0xea15f5b6.Count; _0x8fd40744++)
            if (this._0xea15f5b6[_0x8fd40744] != null)
                this._0xea15f5b6[_0x8fd40744].DOFade(0f, _0x824c4120);
    }

    private const float ThicknessShare = 0.12f;
    public void _0x7454c92c()
    {
        DOTween.Kill(this);
        for (int _0x821689e1 = 0; _0x821689e1 < this._0xea15f5b6.Count; _0x821689e1++)
            if (this._0xea15f5b6[_0x821689e1] != null)
                Destroy(this._0xea15f5b6[_0x821689e1].gameObject);
        this._0xea15f5b6.Clear();
        if (this._0x7f1a2b1b != null)
            this._0x7f1a2b1b.gameObject.SetActive(false);
    }

    [SerializeField]
    private Transform _beamRoot;
    private readonly List<Vector3> _0x68ff7408 = new List<Vector3>(48);
    private const float RunSeconds = 1.6f;
    private void _0x09118319(float _0xb2159790)
    {
        if (this._sparkPrefab == null || this._0x68ff7408.Count < 2)
            return;
        if (this._0x7f1a2b1b == null)
        {
            GameObject _0x535e0768 = Instantiate(this._sparkPrefab, this._beamRoot);
            this._0x7f1a2b1b = _0x535e0768.transform;
            this._0xf37cbc56 = _0x535e0768.GetComponent<SpriteRenderer>();
        }

        this._0x7f1a2b1b.gameObject.SetActive(true);
        this._0x7f1a2b1b.localScale = Vector3.one;
        if (this._0xf37cbc56 != null)
        {
            this._0xf37cbc56.size = new Vector2(_0xb2159790 * SparkShare, _0xb2159790 * SparkShare);
            this._0xf37cbc56.color = _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, 0.95f);
        }

        DOTween.Kill(this);
        this._0x8bf852cc = 0f;
        this._0x7a8294a6(0f);
        DOTween.To(() => this._0x8bf852cc, (float _0xde775227) =>
        {
            this._0x8bf852cc = _0xde775227;
            this._0x7a8294a6(_0xde775227);
        }, 1f, RunSeconds).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart).SetId(this);
    }

    private const float SparkShare = 0.34f;
    private const float BeadShare = 0.26f;
    public void _0xa0e22eb1(_0xf17f6a90 _0x2303038d, _0xc136060f _0x2e7bcdf1, _0xa7f280da _0xe96d9444, bool _0x58e54c04)
    {
        this._0x7454c92c();
        if (_0x2303038d == null || _0x2e7bcdf1 == null || _0xe96d9444 == null || this._beamRoot == null)
            return;
        float _0xd3f5f312 = _0x2303038d._0xc767a88c;
        if (_0xd3f5f312 <= 0f)
            return;
        this._0x68ff7408.Clear();
        for (int _0x67655f76 = 0; _0x67655f76 < _0xe96d9444.Path.Count; _0x67655f76++)
            this._0x68ff7408.Add(_0x2303038d._0xd8b4ec99(_0xe96d9444.Path[_0x67655f76]));
        if (this._0x68ff7408.Count < 2)
            return;
        Color _0xb5d21718 = _0xe96d9444.HitBlocker ? _0xc95d1bd8.Rose : _0xc95d1bd8.Beam;
        float _0x8582fc40 = _0xd3f5f312 * ThicknessShare;
        for (int _0x7c7283b4 = 0; _0x7c7283b4 < this._0x68ff7408.Count - 1; _0x7c7283b4++)
        {
            Vector3 _0x2d1c899f = this._0x68ff7408[_0x7c7283b4];
            Vector3 _0xa14877e1 = this._0x68ff7408[_0x7c7283b4 + 1];
            Vector3 _0xb17459c4 = _0xa14877e1 - _0x2d1c899f;
            float _0xef721d71 = _0xb17459c4.magnitude;
            if (_0xef721d71 <= 0.0001f || this._linkPrefab == null)
                continue;
            GameObject _0x449efda9 = Instantiate(this._linkPrefab, this._beamRoot);
            _0x449efda9.transform.position = _0x2d1c899f + _0xb17459c4 * 0.5f;
            _0x449efda9.transform.localScale = Vector3.one;
            _0x449efda9.transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.Atan2(_0xb17459c4.y, _0xb17459c4.x) * Mathf.Rad2Deg);
            SpriteRenderer _0x6218153a = _0x449efda9.GetComponent<SpriteRenderer>();
            if (_0x6218153a == null)
                continue;
            _0x6218153a.size = new Vector2(_0xef721d71, _0x8582fc40);
            float _0x90116093 = 1f - 0.45f * (float)_0x7c7283b4 / Mathf.Max(1, this._0x68ff7408.Count - 1);
            _0x6218153a.color = _0xc95d1bd8.WithAlpha(_0xb5d21718, _0x90116093);
            this._0xea15f5b6.Add(_0x6218153a);
        }

        // beads sit on the corners, which is where two bars meet at an angle
        if (this._beadPrefab != null)
        {
            for (int _0xb792c075 = 1; _0xb792c075 < this._0x68ff7408.Count - 1; _0xb792c075++)
            {
                Vector3 _0x4cec7ab6 = this._0x68ff7408[_0xb792c075] - this._0x68ff7408[_0xb792c075 - 1];
                Vector3 _0x088c1dc1 = this._0x68ff7408[_0xb792c075 + 1] - this._0x68ff7408[_0xb792c075];
                if (Vector3.Angle(_0x4cec7ab6, _0x088c1dc1) < 1f)
                    continue;
                GameObject _0x673a705d = Instantiate(this._beadPrefab, this._beamRoot);
                _0x673a705d.transform.position = this._0x68ff7408[_0xb792c075];
                _0x673a705d.transform.localScale = Vector3.one;
                SpriteRenderer _0x50b2f16f = _0x673a705d.GetComponent<SpriteRenderer>();
                if (_0x50b2f16f == null)
                    continue;
                _0x50b2f16f.size = new Vector2(_0xd3f5f312 * BeadShare, _0xd3f5f312 * BeadShare);
                _0x50b2f16f.color = _0xc95d1bd8.WithAlpha(_0xc95d1bd8.BeamPale, 0.95f);
                this._0xea15f5b6.Add(_0x50b2f16f);
            }
        }

        this._0x09118319(_0xd3f5f312);
        if (!_0x58e54c04)
            return;
        for (int _0x46df10c9 = 0; _0x46df10c9 < this._0xea15f5b6.Count; _0x46df10c9++)
        {
            SpriteRenderer _0xf4a816c7 = this._0xea15f5b6[_0x46df10c9];
            if (_0xf4a816c7 == null)
                continue;
            Color _0x425d668e = _0xf4a816c7.color;
            _0xf4a816c7.color = _0xc95d1bd8.WithAlpha(_0xc95d1bd8.Cream, _0x425d668e.a);
            _0xf4a816c7.DOColor(_0x425d668e, 0.3f);
        }
    }

    private float _0x8bf852cc;
    private Transform _0x7f1a2b1b;
    private SpriteRenderer _0xf37cbc56;
    [SerializeField]
    private GameObject _linkPrefab;
    /// <summary>Walks the polyline by arc length so the spark keeps a constant speed.</summary>
    private void _0x7a8294a6(float _0xca79d077)
    {
        if (this._0x7f1a2b1b == null || this._0x68ff7408.Count < 2)
            return;
        float _0x2f3eb473 = 0f;
        for (int _0xe2e454e2 = 0; _0xe2e454e2 < this._0x68ff7408.Count - 1; _0xe2e454e2++)
            _0x2f3eb473 += (this._0x68ff7408[_0xe2e454e2 + 1] - this._0x68ff7408[_0xe2e454e2]).magnitude;
        if (_0x2f3eb473 <= 0.0001f)
            return;
        float _0xa379910a = Mathf.Clamp01(_0xca79d077) * _0x2f3eb473;
        for (int _0x29afa747 = 0; _0x29afa747 < this._0x68ff7408.Count - 1; _0x29afa747++)
        {
            float span = (this._0x68ff7408[_0x29afa747 + 1] - this._0x68ff7408[_0x29afa747]).magnitude;
            if (_0xa379910a > span && _0x29afa747 < this._0x68ff7408.Count - 2)
            {
                _0xa379910a -= span;
                continue;
            }

            float _0xedd11fa2 = span <= 0.0001f ? 0f : Mathf.Clamp01(_0xa379910a / span);
            this._0x7f1a2b1b.position = Vector3.Lerp(this._0x68ff7408[_0x29afa747], this._0x68ff7408[_0x29afa747 + 1], _0xedd11fa2);
            return;
        }
    }
}