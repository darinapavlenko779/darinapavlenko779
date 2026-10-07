using System;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Turns one screen tap into one world point.
///
/// The template's own InputController cannot be reached from generated code - its
/// Instance field and every accessor on it are private, so the calls the rule file
/// suggests do not even compile here. Taps therefore come from a single almost
/// transparent Image stretched over the play area, built as the FIRST child of the
/// HUD host so every control added afterwards is a later sibling and wins the
/// raycast; only taps that miss the UI reach the lattice.
/// </summary>
public sealed class _0xa25c9eec : MonoBehaviour, IPointerClickHandler
{
    public void _0x5fda9025(Camera _0xd8611426, Action<Vector3> _0x15b7e56c)
    {
        this._0xffadb7c0 = _0xd8611426;
        this._0xfbf84be8 = _0x15b7e56c;
    }

    public void OnPointerClick(PointerEventData _0x67f89c5a)
    {
        if (this._0xffadb7c0 == null || this._0xfbf84be8 == null || _0x67f89c5a == null)
            return;
        float _0x284d518c = Mathf.Abs(this._0xffadb7c0.transform.position.z);
        Vector3 _0xff1c7f7f = new Vector3(_0x67f89c5a.position.x, _0x67f89c5a.position.y, _0x284d518c <= 0.01f ? 10f : _0x284d518c);
        Vector3 _0x994eb09a = this._0xffadb7c0.ScreenToWorldPoint(_0xff1c7f7f);
        _0x994eb09a.z = 0f;
        this._0xfbf84be8(_0x994eb09a);
    }

    private Action<Vector3> _0xfbf84be8;
    private Camera _0xffadb7c0;
}