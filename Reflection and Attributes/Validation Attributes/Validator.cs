using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (var prop in properties)
            {
                var atribute = prop.GetCustomAttributes()
                    .Where(x => x.GetType().IsSubclassOf(typeof(MyValidationAttribute)))
                   .ToArray();

                foreach (MyValidationAttribute atr in atribute)
                {
                    bool isVALID = atr.IsValid(prop.GetValue(obj));
                    if (!isVALID)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
