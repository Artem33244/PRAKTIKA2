using ClassLibrary1;

        QuadraticEquationSolver equation = new QuadraticEquationSolver(1, -5, 6);
        equation.Solve();
        Console.WriteLine("a = {0}, b = {1}, c = {2}", equation.GetA(), equation.GetB(), equation.GetC());
        Console.WriteLine("x1 = {0}, x2 = {1}", equation.GetX1(), equation.GetX2());