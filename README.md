# dotnet-learn

## .NET CLI Usage
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

### Projects in repository
* [Basics](https://docs.microsoft.com/en-us/dotnet/csharp/)


### Code Style Rules and Formatter
Formatter for this project: [dotnet-format](https://github.com/dotnet/format)
```
dotnet tool install -g dotnet-format
```
All rules are inherited from official configuration from Microsoft DOCS except of shown below.
In order to change them edit `.editorconfig` file and run `dotnet format -w -a info -s info` 
```
root = true

[*.cs]

insert_final_newline = true
max_line_length = 100

csharp_new_line_before_catch = false
csharp_new_line_before_else = false
csharp_new_line_before_finally = false
csharp_new_line_before_open_brace = none
csharp_new_line_between_query_expression_clauses = true
csharp_indent_case_contents_when_block = false

csharp_style_expression_bodied_constructors = false
csharp_style_expression_bodied_methods = false
csharp_style_expression_bodied_local_functions = false

csharp_using_directive_placement = outside_namespace
dotnet_sort_system_directives_first = true

csharp_style_var_for_built_in_types = false
csharp_style_var_when_type_is_apparent = false
csharp_style_var_elsewhere = false

csharp_style_prefer_switch_expression = false
csharp_prefer_simple_using_statement = false
csharp_preserve_single_line_statements = false
csharp_prefer_static_local_function = false

csharp_style_implicit_object_creation_when_type_is_apparent = false
s
dotnet_diagnostic.IDE0001.severity = none
dotnet_diagnostic.IDE0059.severity = none
dotnet_diagnostic.IDE0002.severity = warning
dotnet_diagnostic.IDE0004.severity = warning
dotnet_diagnostic.IDE0005.severity = warning
dotnet_diagnostic.IDE0051.severity = warning
dotnet_diagnostic.IDE0055.severity = warning
dotnet_diagnostic.IDE0080.severity = warning
dotnet_diagnostic.IDE0100.severity = warning
dotnet_diagnostic.IDE0110.severity = warning

dotnet_code_quality.CA1822.api_surface = none
```
