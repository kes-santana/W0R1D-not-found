namespace WhereWorldsFade.Scripts.Classes;

public abstract class LevelCreator
{
    public abstract Level CreateLevel();

    public Level RequestLevel(LevelType levelType)
    {
        Level level = CreateLevel();
        level.Create();
        return level;
    }
}

public class CityLevelCreator : LevelCreator
{
    public override Level CreateLevel() => new CityLevel();
}

public class CityUndergroundLevelCreator : LevelCreator
{
    public override Level CreateLevel() => new CityUndergroundLevel();
}