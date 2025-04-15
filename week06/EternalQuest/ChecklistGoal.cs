public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description} - {_points} points (Checklist)";
    }

    public override int GetPoints()
    {
        int totalPoints = _amountCompleted * _points;
        if (IsComplete())
        {
            totalPoints += _bonus;
        }
        return totalPoints;
    }
}