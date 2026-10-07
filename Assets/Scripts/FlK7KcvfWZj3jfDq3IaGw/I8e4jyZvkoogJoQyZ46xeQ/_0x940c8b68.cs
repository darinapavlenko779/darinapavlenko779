using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x3beca35c;

public class _0x940c8b68 : MonoBehaviour
{
    public Transform EnvironmentWithTweensToToggle;
    public static bool IsAfterLevelFailed = false;
    private static _0x3f9a0ef4 _0x2b9adcf2 => _0x3f9a0ef4.ALL_SCENES_SETTING_SINGLETONS[0];

    public Button ShowResetTutorialButton;
    private void Start()
    {
        if (this._0x442a294c != _0xc6939daa.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0xc6939daa.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xcdcbab5f._0x48029de6 = false;
            _0x7b505880.Instance._0xa077288f();
            _0x7ed5945d.Instance._0xdfd1f132(_0x7817e4f1.TUTORIAL0);
        });
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x940c8b68>();
        this.RootGameObject = GameObject.FindWithTag(_0x3720fe5a._0x2313fc03(new byte[4] { 65, 124, 124, 103 }, 19));
        if (this._0x442a294c == _0xc6939daa.SCENE_0)
            this._0x775f3f6a(true);
        else
            this._0x775f3f6a(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x72c47f94>(true).ToList();
    }

    private void _0x50fd664c(bool _0x47161d14)
    {
        Rigidbody2D[] _0x20e0b1e3 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xe095f999 in _0x20e0b1e3)
            if (_0x47161d14)
                _0xe095f999.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xe095f999.constraints = RigidbodyConstraints2D.None;
    }

    public void _0x216c67a7()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public int _0x442a294c => SceneManager.GetActiveScene().buildIndex;

    public static bool IsAfterLevelComplete;
    public static _0x3f9a0ef4 _0xcdcbab5f => _0x3f9a0ef4.ALL_SCENES_SETTING_SINGLETONS[Instance._0x442a294c];

    private static _0x3f9a0ef4 GAME_INDEX_SETTINGS(int _0x855148fe)
    {
        return _0x3f9a0ef4.ALL_SCENES_SETTING_SINGLETONS[_0x855148fe];
    }

    private IEnumerator _0xc5bf7864(string _0x82da1d84)
    {
        _0x7ed5945d.Instance._0xdfd1f132(_0x7817e4f1.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xff5a33a8 = SceneManager.LoadSceneAsync(_0x82da1d84);
        while (!_0xff5a33a8.isDone)
            yield return null;
    }

    private void _0x4da7a5e7(Transform _0x76823cc7)
    {
        Transform[] _0x4de22ab3 = _0x76823cc7.GetComponentsInChildren<Transform>();
        foreach (Transform _0x7f0e78d1 in _0x4de22ab3)
            if (_0x7f0e78d1 != null && DOTween.IsTweening(_0x7f0e78d1))
            {
                if (this._0x2de945c8)
                    DOTween.Play(_0x7f0e78d1);
                else
                    DOTween.Pause(_0x7f0e78d1);
            }
    }

    public static _0x940c8b68 Instance;
    public Button DeleteProgressDataButton;
    public bool _0x2de945c8 { get; private set; }

    private static void MakeGrid(List<RectTransform> _0xfa60797e, AspectRatioFitter _0xee6c1917, float _0x90f2433b, int _0x6070edd9, int _0xc19c1e64)
    {
        _0xee6c1917.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xee6c1917.aspectRatio = _0x90f2433b;
        foreach (RectTransform _0xf7e80d8e in _0xfa60797e)
        {
            int _0xca782095 = _0xf7e80d8e.transform.GetSiblingIndex();
            _0xf7e80d8e.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xca782095 % _0x6070edd9) * (1f / _0x6070edd9), (_0xc19c1e64 - (Mathf.FloorToInt((float)_0xca782095 / _0x6070edd9) % _0xc19c1e64 + 1f)) * (1f / _0xc19c1e64));
            _0xf7e80d8e.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xca782095 % _0x6070edd9 + 1f) * (1f / _0x6070edd9), (_0xc19c1e64 - Mathf.FloorToInt((float)_0xca782095 / _0x6070edd9) % _0xc19c1e64) * (1f / _0xc19c1e64));
            _0xf7e80d8e.offsetMin = Vector2.zero;
            _0xf7e80d8e.offsetMax = Vector2.zero;
        }
    }

    public void _0x56ca3645()
    {
        _0xcdcbab5f._0x48029de6 = true;
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public void _0x4ea1cc1f()
    {
        foreach (_0x72c47f94 _0xe487d784 in this.MoneyCountContainers)
            _0xe487d784._0xdf934737();
    }

    public Canvas MainCanvas;
    private IEnumerator _0xd063e2d4(int _0xc39a55a5)
    {
        _0x7ed5945d.Instance._0xdfd1f132(_0x7817e4f1.SPLASH);
        AsyncOperation _0xde6aabc3 = SceneManager.LoadSceneAsync(_0xc39a55a5);
        while (!_0xde6aabc3.isDone)
            yield return null;
    }

    public void LoadSceneByIndex(int _0x4a843db3)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xd063e2d4(_0x4a843db3));
    }

    public Transform Environment;
    [HideInInspector]
    public List<_0x72c47f94> MoneyCountContainers = new();
    private void _0x7bbdcd33()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0xc6939daa.SCENE_0);
    }

    public void _0x775f3f6a(bool _0x64e84da6)
    {
        this._0x2de945c8 = _0x64e84da6;
        this._0x50fd664c(!this._0x2de945c8);
        Physics2D.simulationMode = this._0x2de945c8 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x4da7a5e7(this.EnvironmentWithTweensToToggle);
    }
}

internal static class _0x3720fe5a
{
    internal static string _0x2313fc03(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}