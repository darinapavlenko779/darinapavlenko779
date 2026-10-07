using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xf221fccc : MonoBehaviour
{
    private bool _0xfa8e62b0 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public Ease Ease = Ease.OutSine;
    public void _0x573891d0()
    {
        this._0x8dff71d0();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x7ed5945d.Instance._0x305e7094(_0x7ed5945d.Instance.CurrentPanelIndex);
    }

    public TMP_Text MainText;
    public void Show()
    {
        this._0x7e0403fb();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x7ed5945d.Instance._0x305e7094(_0x7ed5945d.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0x7e0403fb()
    {
        if (this.OuterBackground != null)
        {
            Image _0xb665ef9a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xb665ef9a, true);
            _0xb665ef9a.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public GameObject OuterBackground;
    private void _0x28500916()
    {
        if (this.OuterBackground != null)
        {
            Image _0xc003f182 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xc003f182, true);
            _0xc003f182.DOFade(0f, this.ScaleDuration);
        }
    }

    public GameObject Content;
    private void _0x8dff71d0()
    {
        if (this.OuterBackground != null)
        {
            Image _0x1a5542d9 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x1a5542d9, true);
            _0x1a5542d9.DOFade(1f, 0f);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x8acf7312();
    }

    private void _0x8acf7312()
    {
        if (this.OuterBackground != null)
        {
            Image _0x16cf3248 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x16cf3248, true);
            _0x16cf3248.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public float ScaleDuration = 0.4f;
    public TMP_Text HeaderText;
    public void _0x8471ef7b()
    {
        this._0x28500916();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public bool IsScaledDownOnAwake = true;
}