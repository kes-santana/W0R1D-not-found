using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace WhereWorldsFade.Scripts.Classes;

public class DungeonMatrix
{
    int sizeX;
    int sizeY;
    Cell[,] map;
    Dictionary<RoomType, int> minSizeX = new();
    public DungeonMatrix(int x, int y)
    {
        sizeX = x;
        sizeY = y;
        map = new Cell[x, y];
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                map[i, j] = new Cell();
            }
        }
    }

    private static bool IsOnBounds(int i, int j, int minX, int minY, int maxX, int maxY)
        => i == minX || i == maxX || j == minY || j == maxY;

    public void AddRoom(int sizeX, int sizeY, Vector2D pos)
    {
        int minX = (int)pos.x;
        int minY = (int)pos.y;
        int maxX = sizeX + minX - 1;
        int maxY = sizeY + minY - 1;
        for (int i = minX; i < maxX; i++)
        {
            for (int j = minY; j < maxY; j++)
            {
                if (IsOnBounds(i, j, minX, minY, maxX, maxY))
                {
                    map[i, j].type = CellType.Wall;
                }
                else
                {
                    map[i, j].type = CellType.Empty;
                }
            }
        }
    }

    public void GenDungeon(int seed)
    {
        Random rand = new(seed);
        Vector2D[] basis = [new(0, 1), new(1, 0)];
        Vector2D initPos = new(rand.Next(0, sizeX), rand.Next(sizeY));

        // AddRoom(minSizeX[RoomType.Start]))
    }
}