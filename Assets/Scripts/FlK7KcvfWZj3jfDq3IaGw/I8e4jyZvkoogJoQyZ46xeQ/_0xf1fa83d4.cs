using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xf1fa83d4 : MonoBehaviour
{
    private Touch? _0x8e98e9e3(Bounds _0xe4cc7608, TouchPhase _0xcb7fec46)
    {
        if (!_0x940c8b68.Instance._0x2de945c8)
            return null;
        foreach (Touch _0x53262962 in Touch.activeTouches)
            if (_0x53262962.phase == _0xcb7fec46)
            {
                Vector3 _0x7eff00ac = Camera.main.ScreenToWorldPoint(_0x53262962.screenPosition);
                Vector3 _0x067d6aa3 = new(_0x7eff00ac.x, _0x7eff00ac.y, _0xe4cc7608.center.z);
                if (_0xe4cc7608.Contains(_0x067d6aa3) && this._0xb4b1443f(_0x53262962))
                    return _0x53262962;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xbe5e38ea = this.gameObject.GetComponent<_0xf1fa83d4>();
    }

    public BoxCollider2D CameraTouchBounds;
    private bool _0x9835879c(Touch? _0x6fb00995, Bounds _0xc2b4fb47, TouchPhase _0x2218bf05)
    {
        if (!_0x940c8b68.Instance._0x2de945c8)
        {
            _0x6fb00995 = null;
            return false;
        }

        if (_0x6fb00995 != null)
            if (_0x6fb00995.Value.phase == _0x2218bf05)
            {
                Vector3 _0xd89285ff = Camera.main.ScreenToWorldPoint(_0x6fb00995.Value.screenPosition);
                Vector3 _0x277a7316 = new(_0xd89285ff.x, _0xd89285ff.y, _0xc2b4fb47.center.z);
                if (_0xc2b4fb47.Contains(_0x277a7316) && this._0xb4b1443f(_0x6fb00995.Value))
                    return true;
            }

        return false;
    }

    private void _0x7346b907(Touch? _0xd6c0fbb0)
    {
        if (!_0x940c8b68.Instance._0x2de945c8)
        {
            _0xd6c0fbb0 = null;
            return;
        }

        int _0x8fb19160 = _0xd6c0fbb0.Value.touchId;
        _0xd6c0fbb0 = Touch.activeTouches.FirstOrDefault(_0xc6b1d498 => _0xc6b1d498.touchId == _0x8fb19160);
        if (!this._0xb4b1443f(_0xd6c0fbb0.Value))
            _0xd6c0fbb0 = null;
    }

    private Touch? _0xc30b99c7()
    {
        if (!_0x940c8b68.Instance._0x2de945c8)
            return null;
        foreach (Touch _0x0c06715b in Touch.activeTouches)
            if (_0x0c06715b.ended)
                if (this._0xb4b1443f(_0x0c06715b))
                    return _0x0c06715b;
        return null;
    }

    private Touch? _0xd36dcf4a(Bounds _0x620c50c5)
    {
        if (!_0x940c8b68.Instance._0x2de945c8)
            return null;
        foreach (Touch _0x9849121d in Touch.activeTouches)
            if (!_0x9849121d.ended)
            {
                Vector3 _0xc2a3f9a7 = Camera.main.ScreenToWorldPoint(_0x9849121d.screenPosition);
                Vector3 _0x57f7de35 = new(_0xc2a3f9a7.x, _0xc2a3f9a7.y, _0x620c50c5.center.z);
                if (_0x620c50c5.Contains(_0x57f7de35) && this._0xb4b1443f(_0x9849121d))
                    return _0x9849121d;
            }

        return null;
    }

    private static _0xf1fa83d4 _0xbe5e38ea;
    private Touch? _0x51454086(Bounds _0x3ce410ad)
    {
        if (!_0x940c8b68.Instance._0x2de945c8)
            return null;
        foreach (Touch _0x84d30a26 in Touch.activeTouches)
            if (_0x84d30a26.ended)
            {
                Vector3 _0xb480df95 = Camera.main.ScreenToWorldPoint(_0x84d30a26.screenPosition);
                Vector3 _0x38abda81 = new(_0xb480df95.x, _0xb480df95.y, _0x3ce410ad.center.z);
                if (_0x3ce410ad.Contains(_0x38abda81) && this._0xb4b1443f(_0x84d30a26))
                    return _0x84d30a26;
            }

        return null;
    }

    private bool _0xb4b1443f(Touch? _0x2bdc3991)
    {
        if (!_0x2bdc3991.HasValue)
            return false;
        Vector3 _0x60b12a70 = Camera.main.ScreenToWorldPoint(_0x2bdc3991.Value.screenPosition);
        Vector3 _0x6d3f7933 = _0x60b12a70;
        _0x6d3f7933.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x6d3f7933))
            return true;
        _0x2bdc3991 = null;
        return false;
    }

    private Touch? _0x67188963()
    {
        if (!_0x940c8b68.Instance._0x2de945c8)
            return null;
        foreach (Touch _0xa3fd30dd in Touch.activeTouches)
            if (!_0xa3fd30dd.ended)
                if (this._0xb4b1443f(_0xa3fd30dd))
                    return _0xa3fd30dd;
        return null;
    }
}