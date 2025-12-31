
1
Calculator (+, -, *, /)
Temperature converter (Celsius ↔ Fahrenheit)

This bug teaches you about C# type inference rules:

Literals without suffixes are int by default

Operations on integers produce integers (truncating decimal)

Mixed operations follow promotion rules:

int op double → double

int op decimal → decimal

int op float → float