using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class TestMethods
    {
        /// <summary>
        /// Mutiply 2 specified floating point numbers and returns the result
        /// </summary>
        /// <param name="a">first floating point to multiply</param>
        /// <param name="b">second floating point to multiply</param>
        /// <returns></returns>
        public string MultiplyLimited(double a, double b)
        {
            // ensure the type of both arguments is float, this will never fail in a strongly typed language.
            if(a.GetType() != typeof(double) || b.GetType() != typeof(double))
            {
                throw new ArgumentException("Arguments to MultiplyLimited must both be float!");
            }

            // when a or b is out of range, throw exception.
            if (!((1500.0 <= a && a <= 6700.0)
                && (1500.0 <= b && b <= 6700.0)))
            {
                throw new ArgumentOutOfRangeException("Arguments to MultiplyLimited must both be within range!");
            }

            return Math.Round(a * b, 5).ToString("0.#####");
        }

        /// <summary>
        /// Performs a case sensitive search
        /// </summary>
        /// <param name="find">string to find</param>
        /// <param name="target">string to search</param>
        /// <returns></returns>
        public bool IsSubstring(string find, string target)
        {
            bool validParams = ValidateSubstringParameters(find, target);

            if (!validParams)
            {
                return validParams;
            }

            return target.IndexOf(find, StringComparison.Ordinal) >= 0;
        }

        /// <summary>
        /// Performs a case insensitive search
        /// </summary>
        /// <param name="find">string to find</param>
        /// <param name="target">string to search</param>
        /// <returns></returns>
        public bool IsSubstringIgnoreCase(string find, string target)
        {
            bool validParams = ValidateSubstringParameters(find, target);

            if (!validParams)
            {
                return validParams;
            }

            return target.IndexOf(find, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        /// <summary>
        /// Parameter validation shared by IsSubstringCaseSensitive and IsSubstring.
        /// Ensure parameters are specified, are strings and the string to find is
        /// shorter or equal length to the target string to search.
        /// </summary>
        /// <param name="find">string to find</param>
        /// <param name="target">string to search</param>
        /// <returns></returns>
        private bool ValidateSubstringParameters(string find, string target)
        {
            bool validParams = true;

            try
            {

                if (find == null || target == null)
                {
                    return false;
                }

                if (find.GetType() != typeof(string) || target.GetType() != typeof(string))
                {
                    return false;
                }

                if (target.Length < find.Length)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Log Error
                //LogException(ex)
                validParams = false;
            }

            return validParams;
        }

        /// <summary>
        /// Determines whether a specified number is a power of 2.
        /// </summary>
        /// <param name="number">number to check</param>
        /// <returns></returns>
        public bool IsPowerOf2(double number)
        {
            double result = Math.Log(number, 2);
            double remainder = result % 1;
            return remainder == 0.0;
        }
    }
}
