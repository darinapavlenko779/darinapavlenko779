using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x9cd84aa7 : MonoBehaviour
{
    private void Update()
    {
        int _0x52f04e0f = 1;
        if (this._0xd6bc3497.Count > 0)
        {
            string _0x1d23fac5 = this._0x6d94e7e2.text;
            foreach (string _0xa15163dd in this._0xd6bc3497)
                while (_0x1d23fac5.Contains(_0xa15163dd))
                    _0x1d23fac5 = _0x1d23fac5.Replace(_0xa15163dd, "");
            _0x52f04e0f = _0x1d23fac5.Length;
        }
        else
        {
            _0x52f04e0f = this._0x6d94e7e2.text.Length;
        }

        float _0xe483c78a = Mathf.Clamp(this._0xfd1541a0 + this._0x355d3433 * _0x52f04e0f, this._0xe718f9fa, this._0xed14f5f6);
        if (!Mathf.Approximately(this._0x711af453.aspectRatio, _0xe483c78a))
            this._0x711af453.aspectRatio = _0xe483c78a;
    }

    private float _0xed14f5f6 = 4;
    private float _0xe718f9fa = 1.5f;
    private float _0x355d3433 = 0.6f;
    private float _0xfd1541a0;
    private AspectRatioFitter _0x711af453;
    private List<string> _0xd6bc3497 = new();
    private TMP_Text _0x6d94e7e2;
}