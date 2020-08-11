# ACTools: Saving
<hr/>

## public class SaveSystem
<hr/>
### Binary
<br>
<ul>
	<li>
		<p>public void SaveDataToBinaryFile<T>(string projectName, string dataName, T data)</p>
		<p>Saves game data to a binary file.</p>
		<p>T: Type of data being saved.</p>
		<p>projectName: The name of your project. This should ideally be the same for all save files for this game for convenience.</p>
		<p>dataName: A name for the data. This is be apart of the path for saving it. Make sure it's unique.</p>
		<p>data: Data to be saved.</p>
	</li>
	<li>
		<p>public void LoadDataFromBinaryFile<T>(string projectName, string dataName)</p>
		<p>Saves game data to a binary file.</p>
		<p>T: Type of data being saved.</p>
		<p>projectName: The name of your project. This should ideally be the same for all save files for this game for convenience.</p>
		<p>dataName: A name for the data. This is be apart of the path for saving it. Make sure it's unique.</p>
		<p>Returns: Returns the data if it exists. If it doesn't, returns the default of that type.</p>
	</li>
</ul>
<br>
<hr/>