using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{

    public BonusType Bonus {get; set;}
    public int Row {get; set;}
    public int Col {get; set;}

    public string Type {get; set;}

    public Candy(){
        Bonus = BonusType.None;
    }

    public bool IsSameType(Candy otherCandy){
        return string.Compare(this.Type, otherCandy.type) == 0;
    }

    public void Initialize(string type, int row, int col){
        Col = col;
        Row = row;
        Type = type;
    }

    public static void SwapRowCol(Candy c1, Candy c2){
        int temp = c1.Row;
        c1.Row = c2.Row;
        c2.Row = temp;

        temp = c1.Col;
        c1.Col = c2.Col;
        c2.Col = temp;
    }

}
