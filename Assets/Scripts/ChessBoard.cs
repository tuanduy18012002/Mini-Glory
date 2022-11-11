using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    public GameObject cell;
    public int size_row;
    public int size_col;

    Cell[][] m_cells;
    // Start is called before the first frame update
    void Start()
    {
        DisplayChessBoard(size_row, size_col);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayChessBoard(int n_row, int n_col)
    {
        m_cells = new Cell[n_row][];

        for (int i = 0; i < n_row; i++)
        {
            m_cells[i] = new Cell[n_col];
            for (int j = 0; j < n_col; j++)
            {
                GameObject clone = DisplayCell(-i, 0, j);
                m_cells[i][j] = clone.GetComponent<Cell>();
                if ((i + j ) % 2 == 0)
                {
                    m_cells[i][j].ChangeColor(0);
                }
                else
                {
                    m_cells[i][j].ChangeColor(1);
                }
            }
        }
    }

    GameObject DisplayCell(float posX, float posY, float posZ)
    {
        Vector3 spawnPos = new Vector3(posX, posY, posZ);
        return Instantiate(cell, spawnPos, Quaternion.identity) as GameObject;
    }
}
