using System;
using System.Collections.Generic;

namespace WhereWorldsFade.Scripts.Classes;

public abstract class Level
{
    Cell[,] map;

    public abstract void Create();

    public int GetLengthX() => map.GetLength(0);

    public int GetLengthY() => map.GetLength(1);
}

public class CityLevel : Level
{
    public override void Create()
    {
        throw new NotImplementedException();
    }
}

public class CityUndergroundLevel : Level
{
    public override void Create()
    {
        throw new NotImplementedException();
    }

}