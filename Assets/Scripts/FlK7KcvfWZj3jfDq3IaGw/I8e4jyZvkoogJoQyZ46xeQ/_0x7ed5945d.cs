using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x3beca35c;

public class _0x7ed5945d : MonoBehaviour
{
    public int CurrentPanelIndex;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public static _0x7ed5945d Instance;
    private void _0x4655b9ec(int _0x1f2ed4af)
    {
        this.LastPanelIndexes.Add(_0x1f2ed4af);
        this.CurrentPanelIndex = _0x1f2ed4af;
        for (int _0x7e7d9fd1 = 0; _0x7e7d9fd1 < this.Panels.Count; _0x7e7d9fd1++)
            if (_0x7e7d9fd1 != _0x1f2ed4af && this.Panels[_0x7e7d9fd1] != null)
                this.Panels[_0x7e7d9fd1]._0x8471ef7b();
    }

    private void _0x12946ef7(int _0x39210ccf)
    {
        this._0x4655b9ec(_0x39210ccf);
        this._0x5986c40f(_0x39210ccf);
        this.CurrentPanelIndex = _0x39210ccf;
        this.Panels[_0x39210ccf]._0x573891d0();
    }

    private _0xf221fccc _0xa1809bb9(int _0x08d1edc5)
    {
        return this.Panels[_0x08d1edc5];
    }

    private void SwitchSplash()
    {
        if (_0xc303eb22.Instance.IsTutorialEnabled && !_0x940c8b68._0xcdcbab5f._0x48029de6)
            this._0xdfd1f132(_0x7817e4f1.TUTORIAL0);
        else
            this._0xdfd1f132(_0x7817e4f1.DEFAULT);
    }

    private void _0x6358310b(int _0x7540ad13)
    {
        this.LastPanelIndexes.Add(_0x7540ad13);
        this.CurrentPanelIndex = _0x7540ad13;
        for (int _0x24df4d1b = 0; _0x24df4d1b < this.Panels.Count; _0x24df4d1b++)
            if (_0x24df4d1b != _0x7540ad13 && this.Panels[_0x24df4d1b] != null)
                this.Panels[_0x24df4d1b]._0x8471ef7b();
    }

    public void _0x305e7094(int _0x7cd29c88)
    {
        if (_0x7cd29c88 == _0x7817e4f1.SPLASH && _0x940c8b68.Instance._0x442a294c != _0xc6939daa.SCENE_0)
            _0x72c0b5aa.Instance._0x3f2f6b83();
        if (_0x940c8b68.Instance._0x442a294c != _0xc6939daa.SCENE_0)
        {
            if (_0x7cd29c88 == _0x7817e4f1.SPLASH || _0x7cd29c88 == _0x7817e4f1.TUTORIAL0)
                _0x940c8b68.Instance._0x775f3f6a(false);
            else if (_0x7cd29c88 == _0x7817e4f1.DEFAULT)
                _0x940c8b68.Instance._0x775f3f6a(true);
        }
    }

    public float StaticBlurMaterialInitialValue;
    public List<_0xf221fccc> Panels;
    public void _0x2d154569()
    {
        this.LastPanelIndexes.RemoveAll(_0x69b40d4c => _0x69b40d4c == this.CurrentPanelIndex);
        int _0xca71034a = this.LastPanelIndexes.Last();
        this._0x5986c40f(_0xca71034a);
        this._0x6358310b(_0xca71034a);
        this.CurrentPanelIndex = _0xca71034a;
        this.Panels[_0xca71034a].Show();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x7ed5945d>();
    }

    public float ScaleDuration = 0.4f;
    public bool IsShowSplashOnStart = true;
    public void _0xdfd1f132(int _0xc3e655a7)
    {
        this._0x4655b9ec(_0xc3e655a7);
        this._0x5986c40f(_0xc3e655a7);
        this.CurrentPanelIndex = _0xc3e655a7;
        this.Panels[_0xc3e655a7].Show();
    }

    private void _0x5986c40f(int _0xf0d0f588)
    {
        if (_0xf0d0f588 == _0x7817e4f1.SPLASH)
            _0x72c0b5aa.Instance._0xbca68f9b();
        if (_0x940c8b68.Instance._0x442a294c == _0xc6939daa.SCENE_0)
        {
        }
    }

    private void _0x5687c47e()
    {
        this._0x12946ef7(_0x7817e4f1.SPLASH);
        if (_0x940c8b68.Instance._0x442a294c == _0xc6939daa.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x72c0b5aa.Instance.DefaultAnimationTime);
        }
    }

    private void Start()
    {
        this._0x5687c47e();
    }
}