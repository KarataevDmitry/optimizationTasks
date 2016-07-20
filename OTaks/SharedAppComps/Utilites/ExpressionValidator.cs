using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OptimisationTasks.Utilites
{
    /// <summary>
    /// Результат валидации
    /// </summary>
    public struct ValidationResult
    {
        /// <summary>
        /// <code>true</code> - если выражение валидно
        /// <code>false</code> - в противном случае
        /// </summary>
        public bool IsValid { get; }
        /// <summary>
        /// Пустая строка - если ошибок нет и строка, содержащая ошибку - иначе
        /// </summary>
        public string ErrorIn { get; }
        /// <summary>
        /// Конструктор структуры
        /// </summary>
        /// <param name="isVal"><see cref="IsValid"/></param>
        /// <param name="place"><see cref="ErrorIn"/></param>
        public ValidationResult(bool isVal, string place)
        {
            IsValid = isVal;
            ErrorIn = place;
        }
    }
    /// <summary>
    /// Класс валидатора ввода выражения
    /// </summary>
    public class ExpressionValidator
    {
        /// <summary>
        /// Значение, возвращаемое в <code>ValidationResult.ErrorIn</code>
        /// если выражение валидно
        /// </summary>
        public string VALIDATION_STATUS_OK => "";
        Regex IncorrectMult = new Regex(@"\p{Nd}+.{0,1}\p{Nd}+[a-z]");
        /// <summary>
        /// Осуществляет валидацию выражения <paramref name="expr"/>
        /// </summary>
        /// <param name="expr">Выражение для проверки</param>
        /// <returns>Результат проверки на валидность.
        /// <seealso cref="ValidationResult"/></returns>
        public   ValidationResult Validate(string expr)
        {
            
            
            if (IncorrectMult.IsMatch(expr))
            {
                return new ValidationResult(false, IncorrectMult.Match(expr).Value);
                
            }
            return new ValidationResult(true, VALIDATION_STATUS_OK);
        }
        public ExpressionValidator ( )
        {
            IncorrectMult = new Regex(@"\p{Nd}+.{0,1}\p{Nd}+[a-z]");
        }
    }     
}
