using CSharpExercises.Services;
using CSharpExercises.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CSharpExercises
{
    internal class Program
    {
        static readonly ServiceProvider serviceProvider = SetupServiceProvider();
        static readonly IWordService wordService = serviceProvider.GetService<IWordService>();
        static readonly IProblemService problemService = serviceProvider.GetService<IProblemService>();

        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("----------M-E-N-U----------\n");
                    Console.WriteLine("Select problem to showcase: \n");

                    var listOfProblems = problemService.GetProblemNames().ToList();

                    foreach (var problem in listOfProblems)
                    {
                        var index = listOfProblems.IndexOf(problem);
                            index++;

                        Console.WriteLine($"{index}.- {problem}");
                    }

                    Console.WriteLine("\nEnter input. \nType \"Quit\" to close program.");
                    var userInput = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(userInput))
                        continue;
                                  
                    if (userInput.ToLower() is "quit")
                        break;

                    var problemName = listOfProblems[int.Parse(userInput) - 1];
                    RunProblem(problemName);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error: {exception}");
            }
        }

        private static ServiceProvider SetupServiceProvider()
        {
            var serviceProvider = new ServiceCollection()
            .AddTransient<IWordService, WordService>()
            .AddTransient<IProblemService, ProblemService>()
            .BuildServiceProvider();

            return serviceProvider;
        }

        private static void RunProblem (string problemName)
        {
            var problem = new Problems(wordService);
            var method = typeof(Problems).GetMethod(problemName, BindingFlags.Instance | BindingFlags.NonPublic);
            method.Invoke(problem, null);
        }
        
    }
}