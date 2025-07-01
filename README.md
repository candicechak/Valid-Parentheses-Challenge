# Valid-Parentheses-Challenge

## Progressive Steps

### STEP 1: Basic Validation
Given a string with only '(' and ')' characters, check if it's valid.
Valid = equal number of opening '(' and closing ')' brackets

Examples:
```
"()" → true
"(())" → true
"(()" → false
“)(“ —> true
"()()" -> true
"())" -> false
"()())(" -> true
```

### STEP 2: Validation With Order
Given a string can only start with '(' and equal numbers of ')' characters, check if it's valid.
Valid = equal number of opening '(' and closing ')' brackets with only opening '(' before any extra closing ')'

Examples:
```
"()" → true
"(())" → true
"(()" → false
“)(“ —> true -> false
"()()" -> true
"())" -> false
"()())(" -> true -> false
```