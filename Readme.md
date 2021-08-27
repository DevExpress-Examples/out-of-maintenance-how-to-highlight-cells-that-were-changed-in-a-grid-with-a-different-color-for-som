<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128629170/10.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2441)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CellToPaint.cs](./CS/CellChangedHighlight/CellToPaint.cs) (VB: [CellToPaint.vb](./VB/CellChangedHighlight/CellToPaint.vb))
* [Form1.cs](./CS/CellChangedHighlight/Form1.cs) (VB: [Form1.vb](./VB/CellChangedHighlight/Form1.vb))
<!-- default file list end -->
# How to highlight cells that were changed in a grid with a different color for some time


<p>This example shows how to make cells with values changed by a user painted with a different color. To accomplish this task we created a helper class named CellPaintHelper which does the job. For each cell to be painted an instance of this class is created and the instance processes the grid view's CustomDrawCell event. The cell is highlighted for a time set in the timer's interval property and when the time is up its appearance returns to the default state and the CellPaintHelper class instance for this cell is disposed of.</p>

<br/>


