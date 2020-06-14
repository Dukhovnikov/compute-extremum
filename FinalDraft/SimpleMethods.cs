using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDraft
{
    /// <summary>
    /// Набор методов одномерной минимизации
    /// </summary>
    internal class SimpleMethods
    {
        public string MethodName;

        public SimpleMethods(string MethodName)
        {
            this.MethodName = MethodName;
        }

        public static List<SimpleMethods> GetSimpleMethods()
        {
            return new List<SimpleMethods>
            {
                new SimpleMethods("Больцан-Давидон"),
                new SimpleMethods("Дихотомия"),
                new SimpleMethods("Золотое Сечение-1"),
                new SimpleMethods("Золотое Сечение-2"),
                new SimpleMethods("Кубическая Интерполяция"),
                new SimpleMethods("Пауэлл"),
                new SimpleMethods("Больцано"),
            };
        }
    }
}
