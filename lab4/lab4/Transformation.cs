using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    // Абстрактний клас для трансформації
    abstract class Transformation
    {
        // Віртуальний метод для задання коефіцієнтів перетворення з клавіатури
        public abstract void SetTransformationCoefficientsFromUserInput();

        // Віртуальний метод для виведення коефіцієнтів перетворення на екран
        public abstract void PrintTransformationCoefficients();
    }

}
