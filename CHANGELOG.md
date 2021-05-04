# Changelog
<p>All notable changes to this project will be documented in this file.</p>

## [Unreleased Changes]
<ul>
	<li> </il>
</ul>
<hr/>

## [1.2.0] - 2021-05-04

### Addition:
<ul>
	<li>BinaryFormatterUtility.cs created to manage the new BinaryFormatter.</il>
	<li>BoundsSerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>BoundsIntSerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>ColorSerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>Color32SerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>QuaternionSerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>RectSerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>RectIntSerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>Vector2SerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>Vector3SerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>Vector4SerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>Vector2IntSerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>Vector3IntSerializationSurrogate.cs created to be used in the new BinaryFormatter.</il>
	<li>IDictionarySerializationSurrogate.cs created to be used in the new BinaryFormatter. </il>
</ul>

### Changes:
<ul>
	<li>SaveData.cs updated to use new BinaryFormatter and to allow for additional saves.</il>
	<li>LoadData.cs updated to use new BinaryFormatter and to allow for additional saves.</il>
	<li>Updated ACTools_Saving.md.</il>
	<li>Updated package.json.</il>
</ul>
<hr/>

## [1.0.1] - 2020-09-02

### Changes:
<ul>
	<li>SaveSystem.cs was renamed to SaveData.cs.</il>
	<li>Method SaveDataToBinaryFile in SaveData.cs was renamed to ToBinaryFile.</il>
	<li>Method LoadDataFromBinaryFile in SaveData.cs was renamed to FromBinaryFile.</il>
	<li>LoadData.cs was created and method FromBinaryFile was moved from SaveData.cs to LoadData.cs.</il>
	<li>Updated ACTools_Saving.md to reflect these changes.</il>
</ul>
<hr/>

## [1.0.0] - 2020-08-11

### Additions:
<ul>
	<li>README.md was created to provide information to users.</il>
	<li>CHANGELOG.md was created to track changes.</il>
	<li>ACTools_Saving.md was created for documentation.</il>
</ul>

### Changes:
<ul>
	<li>Package was added to GitHub and the start of the version tracking.</il>
</ul>