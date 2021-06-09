# Summary

This package aims at providing usefull editor extension that can be reused across project.

# Extension Feature List

## Extended scriptable object property drawer

### Description

This feature is based on the script provided by [tomkail](https://gist.github.com/tomkail/ba4136e6aa990f4dc94e0d39ec6a058c) and allows to display the scriptable object properties referenced in a monobheavior's inspector.

Modification done on the original script are the abstraction of the class and removal of the class CustomPropertyDrawer attribute.

This was done to avoid applying by default the property drawer on all scriptable object, which can be confusing if the project makes heavy use of scriptable object (like including the Localization or Addressable package).

### How to use

To use this, you'll need to:

1. Create an Editor folder in your project

2. Use the contextual menu "Assets/Create/WAYN/Editor/ExtendedScriptableObjectDrawer" to create a templated editor script

3. Input the classname of the scriptable object for which you want to make a property drawer 

# Importing to project
##Using GIT
To import this package to your project :
1) Open the PackageManager
2) Click on the "+" icon
3) Add package from git URL
4) Paste the git url of this porject
