using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
                | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder builder = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            builder.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
            {
                builder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return builder.ToString().Trim();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type curentclass = Type.GetType(className);
            FieldInfo[] classField =
                curentclass.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMetod = curentclass.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMetod = curentclass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();


            foreach (FieldInfo field in classField)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (MethodInfo metod in classNonPublicMetod.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{metod.Name} have to be public!");
            }

            foreach (MethodInfo metod in classPublicMetod.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{metod.Name} have to be private!");
            }

            return sb.ToString().TrimEnd();
        }

        public string RevealPrivateMethods(string className)
        {
            Type curentClass = Type.GetType(className);

            MethodInfo[] metodAllPrivate = curentClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sv = new StringBuilder();

            sv.AppendLine($"All Private Methods of Class: {className}");
            sv.AppendLine($"Base Class: {curentClass.BaseType.Name}");

            foreach (MethodInfo metod in metodAllPrivate)
            {
                sv.AppendLine(metod.Name);
            }

            return sv.ToString().TrimEnd();
        }

        public string CollectgetersAndSeters(string className)
        {
            Type curentClass=Type.GetType(className);

            MethodInfo[] allMetod = 
                curentClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder sb = new StringBuilder();

            foreach (MethodInfo metod in allMetod.Where(x=>x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{metod.Name} will return {metod.ReturnType}");
            }

            foreach (MethodInfo method in allMetod.Where(x=>x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
