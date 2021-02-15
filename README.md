| README.md |
|:---|

<div align="center">

<img src="assets/microsoft-solver-foundation-nuget.png" alt="Microsoft Solver Foundation Express - NuGet package" width="100" />

</div>

<h1 align="center">Microsoft Solver Foundation Express - NuGet package</h1>
<div align="center">

Unofficial NuGet package to simplify the development and deployment of .NET applications that use the [Microsoft Solver Foundation Express](https://msdn.microsoft.com/en-us/devlabs/hh145003)  3.0.2.10889 (v3.1).

[![NuGet Version](http://img.shields.io/nuget/v/Unofficial.Microsoft.Solver.Foundation.Express.svg?style=flat-square)](https://www.nuget.org/packages/Unofficial.Microsoft.Solver.Foundation.Express/) [![Stack Overflow](https://img.shields.io/badge/stack%20overflow-ms--solver--foundation-orange.svg)](http://stackoverflow.com/questions/tagged/ms-solver-foundation)

</div>

## Getting started :rocket:

To use the Microsoft Solver Foundation Express in your .NET application, install the [NuGet package](https://www.nuget.org/packages/Unofficial.Microsoft.Solver.Foundation.Express):

```powershell
Install-Package Unofficial.Microsoft.Solver.Foundation.Express
```

Solver Foundation requires .NET Framework v4.0 or higher.

## Microsoft Solver Foundation

![Microsoft Solver Foundation logo](assets/microsoft-solver-foundation.png)

**Solver Foundation** is a pure, managed code runtime for mathematical programming, modeling, and optimization. Solver Foundation uses a declarative programming model, consisting of simple compatible elements that are solved by built-in or third-party solvers that employ operations research, metaheuristic, local search and combinatorial optimization techniques. Building a model in Solver Foundation is as simple as specifying the decisions to be made, constraints to be respected, the goals to be used to evaluate candidate proposals (solutions) and the data to be processed by the model (historical or projected parameters). This can be done from any .Net language and the modeler does not need to understand anything about the details of solver technologies or search strategies. The separation of concerns is total, providing a high degree of modularity.

### Simulation, Optimization, and Modeling

You can use Solver Foundation to simulate problems, find the optimal maximal or minimal value of functions, and model complex systems by using decision variables and constraints. You can use linear programming, quadratic programming, mixed integer linear programming, second order sonic programming, compact quasi-Newton programming, or constraint satisfaction programming in your models.

In addition, you can simulate models and adjust the result by adding uncertainty into models to more accurately reflect reality. Solver Foundation offers simulation and stochastic programming techniques to solve and report the results of two-stage linear stochastic models.

### Supported Hardware

The following table lists the number of processor cores and the RAM supported by Solver Foundation Express.

| Hardware | Microsoft Solver Foundation Express |
| -------- | ----------------------------------- |
| CPU      | 1                                   |
| Cores    | 8                                   |
| RAM      | 8 GB                                |

### Model Size Limits

The following table lists the model size limits for each type of programming in Solver Foundation Express. The model size limits apply to Solver Foundation solvers and not third-party solvers. Third party solvers may have different size limits.

| Programming type                | Microsoft Solver Foundation Express                     |
| ------------------------------- | ------------------------------------------------------- |
| Linear or quadratic programming | 50,000 non-zeros                                        |
| Mixed integer programming       | 1,000 variables, 1,000 constraints, and 5,000 non-zeros |
| Constraint programming          | 5,000 total terms                                       |
| Non-linear programming          | Unlimited                                               |

## Release History

Click on the [Releases](https://github.com/augustoproiete/microsoft-solver-foundation-express-nuget/releases) tab on GitHub.

## License

_Copyright &copy; 2018-2021 C. Augusto Proiete & Contributors - Provided under the [Microsoft Public License (Ms-PL)](LICENSE)._

---

The Microsoft Solver Foundation Express is Copyright (C) 2006-2010 Microsoft Corporation. Microsoft is a registered trademarks of Microsoft Corporation in the United States and/or other countries.
