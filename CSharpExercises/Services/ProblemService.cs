using CSharpExercises.Services.Interfaces;
using System.Reflection;

namespace CSharpExercises.Services
{
    internal class ProblemService : IProblemService
    {
        public IEnumerable<string> GetProblemNames()
        {
            var methods = typeof(Problems).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            var methodNames = methods.Select(method => method.Name).Where(method => method.Contains("Problem"));
            return methodNames;
        }
    }
}