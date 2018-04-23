# How to highlight cells that were changed in a grid with a different color for some time


<p>This example shows how to make cells with values changed by a user painted with a different color. To accomplish this task we created a helper class named CellPaintHelper which does the job. For each cell to be painted an instance of this class is created and the instance processes the grid view's CustomDrawCell event. The cell is highlighted for a time set in the timer's interval property and when the time is up its appearance returns to the default state and the CellPaintHelper class instance for this cell is disposed of.</p>

<br/>


