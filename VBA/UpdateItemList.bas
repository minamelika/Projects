Attribute VB_Name = "UpdateItemList"
Option Explicit
' This function copies values from one sheet "Item Card" to another "Item List"

Sub UpdateItemList()

Dim numRows As Integer
Dim numCols As Integer
Dim rowNum As Integer
Dim colNum As Integer
Dim itmLst As ListObject
Dim lstRow As ListRow

Worksheets("Item_Card").Activate
numRows = Range("A2", Range("A1").End(xlDown)).Count
numCols = Range("A2", Range("A2").End(xlToRight)).Count

Worksheets("Item_List").Activate
Set itmLst = Worksheets("Item_List").ListObjects(1)
Set lstRow = itmLst.ListRows.Add

For rowNum = 1 To numRows

    For colNum = 1 To numCols
    lstRow.Range(rowNum, colNum) = Worksheets("Item_Card").Range("A1").End(xlUp).Offset(rowNum, colNum - 1).Value
    Next colNum
Next rowNum


End Sub
