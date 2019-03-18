# MathEngine

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Build Status](https://massimobonanni.visualstudio.com/MathEngine/_apis/build/status/MathEngine-CI?branchName=develop)](https://massimobonanni.visualstudio.com/MathEngine/_build/latest?definitionId=22&branchName=develop)

![Nuget](https://img.shields.io/nuget/v/MathEngine.svg) ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/MathEngine.svg) 

![Nuget](https://img.shields.io/nuget/dt/MathEngine.svg)

---
**Math Engine** is a demo used to show how you can leverage the power on Azure Pipeline in your GitHub repo.

It implements a simple Math engine that allows you to calculate famous sequence of numbers (e.g. Fibonacci or prime numbers) or to evaluate scalar algorithms.

The `MathEngine` class is the factory class you can use to retrieve e specific calculator:

```csharp
var fibonacciCalculator = MathEngine.CreateSequenceCalculator("fibonacci");
var fibonacciList=fibonacciCalculator.Calculate(1000);
```

## Calculator Interfaces

### Sequence Calculator
A sequence calculator is a class that implements the `ISequenceCalculator` interface:

```csharp
public interface ISequenceCalculator
{
    IEnumerable<double> Calculate(double upperLimit);
}
```

A sequence calculator can evaluate a sequence of number (e.g Fibonacci sequence).

### Scalar Calculator
A scalar calculator is a class that implements the `IScalarCalculator` interface:

```csharp
public interface IScalarCalculator
{
    double Calculate(double arg);
}
```

A scalar calculator can evaluate a math constant or value.
