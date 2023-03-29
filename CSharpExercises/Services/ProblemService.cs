using CSharpExercises.Services.Interfaces;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CSharpExercises.Services
{
    internal class ProblemService : IProblemService
    {
        public IEnumerable<string> GetProblemNames()
        {
            var methods = typeof(Problems).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            var methodNames = methods.Select(method => method.Name).Where(method => method.Contains("Problem"));
            var prettifiedMethodNames = PrettifyMethodNames(methodNames);
            return prettifiedMethodNames;
        }

        private IEnumerable<string> PrettifyMethodNames(IEnumerable<string> methodNames)
        {
            var prettifiedProblemNames = methodNames.Select(problemName => Regex.Replace(problemName, "([A-Z])", " $1", RegexOptions.Compiled));

            return prettifiedProblemNames;
        }

    }
}