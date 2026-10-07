using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x72c0b5aa : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x3beca35c._0xc6939daa.SCENE_0 && !_0xe06009d3)
        {
            this._0xc73ed266();
        }
        else
        {
            this._0x3f2f6b83();
        }
    }

    public void _0x6b5dadb5()
    {
        this._0x9bf33114?.Play();
    }

    public void _0xbca68f9b()
    {
        this._0x9bf33114?.Kill();
        this.AnimationSlider.value = _0xe06009d3 ? this.SecondPassSliderValue : 0.05f;
    }

    private Sequence _0x9bf33114;
    public float SecondPassSliderValue = 0.5f;
    private static bool _0xe06009d3 = false;
    public static _0x72c0b5aa Instance;
    public void _0x3f2f6b83()
    {
        this._0xbca68f9b();
        bool _0x87c3d39c = _0xe06009d3;
        this._0x9bf33114 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xe5b1d7fe => this.AnimationSlider.value = _0xe5b1d7fe, _0x87c3d39c ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xe06009d3 = !_0xe06009d3;
    }

    public GameObject Content;
    public void _0x431e2052()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x9bf33114?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xe06009d3 = false;
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x72c0b5aa>();
    }

    public GameObject Background;
    public void _0xacd5243b()
    {
        this._0x9bf33114?.Pause();
    }

    public GameObject Error;
    public float DefaultAnimationTime = 0.4f;
    public Slider AnimationSlider;
    private void _0xc73ed266()
    {
        this.AnimationSlider.value = 0.05f;
        _0xe06009d3 = !_0xe06009d3;
        this._0x9bf33114 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xe5b1d7fe => this.AnimationSlider.value = _0xe5b1d7fe, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x9018c538._0x74caa470?._0xc0c98601();
        });
    }

    public float FirstAnimationTime = 10.0f;
}