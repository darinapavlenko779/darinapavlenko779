using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x3beca35c;

public class _0x7b505880 : MonoBehaviour
{
    public List<GameObject> GameObjectsToHide;
    public static _0x7b505880 Instance;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x7b505880>();
    }

    public List<_0xea6e75c9> Pops;
    public void _0xc011989b(int _0xc9b1ef52)
    {
        this.CurrentPopIndex = _0xc9b1ef52;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x202d91c5(true);
        this._0x69fe5ce3();
        this.Pops[_0xc9b1ef52].Show();
        foreach (GameObject _0xebfe53a3 in this.GameObjectsToHide)
            _0xebfe53a3.SetActive(false);
    }

    public List<int> LastPopIndexes = new();
    public int CurrentPopIndex;
    public float ScaleDuration = 0.4f;
    public GameObject BlurBackground;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xea6e75c9 _0xa2b37535 in this.Pops)
            if (_0xa2b37535 != null)
                _0xa2b37535.gameObject.SetActive(true);
    }

    public void _0x06270661()
    {
        this.LastPopIndexes.RemoveAll(_0x69b40d4c => _0x69b40d4c == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xa077288f();
        else
            this._0xc011989b(this.LastPopIndexes.Last());
    }

    public void _0xa077288f()
    {
        this.LastPopIndexes.Clear();
        this._0x202d91c5();
        foreach (GameObject _0x9e8a080c in this.GameObjectsToHide)
            if (_0x9e8a080c != null)
                _0x9e8a080c.SetActive(true);
        this._0xf8bc0c5f();
    }

    private void _0xf8bc0c5f()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public _0xea6e75c9 _0xa3b3a463(int _0xfbc0f08e)
    {
        return this.Pops[_0xfbc0f08e];
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void _0x202d91c5(bool _0x1feff07c = false)
    {
        for (int _0x2213faf8 = 0; _0x2213faf8 < this.Pops.Count; ++_0x2213faf8)
            if (this.Pops[_0x2213faf8] != null && !(_0x2213faf8 == this.CurrentPopIndex && _0x1feff07c))
                this.Pops[_0x2213faf8]._0x3f64fb43();
    }

    private void _0x69fe5ce3()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }
}