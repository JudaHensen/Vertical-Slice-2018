using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFeed : MonoBehaviour {

    [Header("Lists for player names, first & lastnames will be randomly combined.")]
    [SerializeField] private List<string> _firstNames = new List<string>();
    [SerializeField] private List<string> _lastNames = new List<string>();
    [SerializeField] private List<string> _userNames = new List<string>();

    [Header("Team colors")]
    [SerializeField] private string _allyTeamColor;
    [SerializeField] private string _enemyTeamColor;

    [Header("Spawn time in seconds")]
    [SerializeField] private float _minimumTime;
    [SerializeField] private float _maximumTime;
  

    [SerializeField] private PlayerKill _playerKill;
    private List<PlayerKill> _killList = new List<PlayerKill>();
    private float _displayTime, _timer;

    [SerializeField] private GameObject _this;


    void Start()
    {
        _displayTime = Random.Range(_minimumTime, _maximumTime);
    }

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _displayTime)
        {
            _timer = 0;
            _displayTime = Random.Range(_minimumTime, _maximumTime);
            DisplayKillFeed();
        }       
    }

    private void DisplayKillFeed()
    {
        string color1, color2, message;
        int id = _killList.Count;

        if (Random.Range(0, 10) > 5)
        {
            color1 = "<color=#" + _allyTeamColor + ">";
            color2 = "<color=#" + _enemyTeamColor + ">";
        }
        else 
        {
            color1 = "<color=#" + _enemyTeamColor + ">"; 
            color2 = "<color=#" + _allyTeamColor + ">";
        }

        message = color1 + GenerateName() + "</color><color=#FFFFFF> KILLED </color>" + color2 + GenerateName() + "</color>";

        PlayerKill _newKill = Instantiate(_playerKill, new Vector2(0,0), Quaternion.identity);
        _newKill.Setup(message);
        _newKill.transform.SetParent(_this.transform);
        _killList.Add(_newKill);

        for(int i = 0; i < _killList.Count; i++)
        {
            if(i != id) _killList[i].ActivateShiftDown();
        }
    }

    private string GenerateName()
    {    
        if( Random.Range(1,4) > 2) // username
        {
            return _userNames[Random.Range(0, _userNames.Count)];
        }
        else // generated name
        {
            string first, last, middle;
            first = _firstNames[Random.Range(0, _firstNames.Count)];
            last = _lastNames[Random.Range(0, _lastNames.Count)];
            if (Random.Range(0, 1) > .5f) middle = "_";
            else middle = " ";

            return first + middle + last;
        }
    }


}
