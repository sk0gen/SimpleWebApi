using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LearnApi.Extensions
{
    public static class EnumExtenstions
    {

        public static string ToDescriptionString<TEnum>(this TEnum _enum)
        {
            FieldInfo info = _enum.GetType().GetField(_enum.ToString());
            var attributes = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes?[0].Description ?? _enum.ToString();
        }

    }
}
