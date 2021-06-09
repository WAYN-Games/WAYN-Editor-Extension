#Summary

This package aims at provideing usefulle editor extension that can be reused accross project.

# Extension Feature List
## Extended scriptable object property drawer
### Description
This feature is based on the script provided by [tomkail](https://gist.github.com/tomkail/ba4136e6aa990f4dc94e0d39ec6a058c) and allows to display the scriptable object properties referenced in a monobheavior's inspector.
Modification done on the original script are the abstraction of the class and removal of the class CustomPropertyDrawer attribute.
This was done to avoid applying by default the property drower on all scriptable object, which can be confusing if the project make heavy use of scriptable object (like including the Localization or Adressable package).
### How to use
To use this you'll need to :
1. create an Editor folder in your project
2. use the contextual menu "Assets/Create/WAYN/Editor/ExtendedScriptableObjectDrawer" to create a tempalted editor script
3. input the classname of the scriptable object you which to make the property drawer for
