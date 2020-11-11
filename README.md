# dotnet-learn

### Creating New Project
* Single solution in git repository
```
dotnet new sln -n $NAME_SLN$ && dotnet new gitignore && dotnet new $TEMPLATE$ -n $NAME_PROJ$ && dotnet sln add $NAME_PROJ$
```
* Multiple solution in git repository
```
mkdir $NAME_SLN$ && cd $NAME_SLN$ && dotnet new sln -n $NAME_SLN$ && dotnet new gitignore && dotnet new $TEMPLATE$ -n $NAME_PROJ$ && dotnet sln add $NAME_PROJ$
```

### Adding New Project To Existing Solution  
```
dotnet new $TEMPLATE$ -n $NAME_PROJ$ && dotnet sln add $NAME_PROJ$
```
