using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Lessons.Builder
{
    //пример клонирования с использованием сериализатора json
    public static class ExtensionDeepCopy
    {
        public static T Copy<T>(this T self)
        {
            string jsonString = JsonSerializer.Serialize(self);
            var copyObject = JsonSerializer.Deserialize<T>(jsonString);

            return copyObject;
        }
    }
}
