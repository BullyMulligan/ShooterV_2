using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCanvas : MonoBehaviour
{
    //сериализуем поля с элементами UI и иконкой
    [SerializeField] private Canvas _canvasEnemyIcons;

    [SerializeField] private TextMeshProUGUI _countBulletsView;

    [SerializeField] private RawImage _icon;

    //создаем стак, чтобы удалять по порядку иконки
    private Stack<RawImage> icons =new Stack<RawImage>();
    
    //метод добавляющий иконки на канвас и добавляющий их в стек
    public void AddIcon()
    {
        _icon = Instantiate(_icon);
        _icon.transform.SetParent(_canvasEnemyIcons.transform,false);
        icons.Push(_icon);
    }

    //метод удаляющий иконки, запускается событием, когда враг уничтожен, четез стек
    public void DelIcon()
    {
        Destroy(icons.Pop());
    }

    //метод дающий информацию об количестве пуль в ружье. Обновляется при выстреле
    public void BulletsCount(int bullets)
    {
        _countBulletsView.text = bullets.ToString();
    }
}
