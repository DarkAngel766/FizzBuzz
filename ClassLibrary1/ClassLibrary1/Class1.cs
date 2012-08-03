using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WillPower.Math.Demo
{

    /// <summary>
    /// This is a demo class for illustrating that Will Osborn can at least
    /// code his way out of a wet paper bag.
    /// </summary>
    public class FizzBuzz
    {

        #region Properties

        /// <summary>
        /// For each key provided, if the input is divisible by it, use the provided value as output.
        /// </summary>
        public Dictionary<int, string> Dividends { get; set; }

        #endregion

        #region Public Methods

        #region Constructors

        /// <summary>
        /// Creates a new instance of this class.
        /// </summary>
        public FizzBuzz()
        { Dividends = new Dictionary<int, string>(); }
        /// <summary>
        /// Creates a new instance of this class.
        /// </summary>
        /// <param name="DivValues">Dictionary[int,string]; the collectionof Dividends and their expected output</param>
        public FizzBuzz(Dictionary<int, string> DivValues)
        { Dividends = DivValues; }

        #endregion

        /// <summary>
        /// Creates the output string based upon provided criterion, including Dividends collection.
        /// </summary>
        /// <param name="Start">int; The number to begin counting at</param>
        /// <param name="Finish">int; the number to end counting at</param>
        /// <param name="Step">int; the increment of the count</param>
        /// <returns>string</returns>
        public string GetOutput(int Start, int Finish, int Step)
        {
            if ((Step == 0) || ((Start > Finish) && (Step > 0)) || ((Start < Finish) && (Step < 0)))
                throw new ApplicationException(string.Format("Invalid Parameters Provided. Cannot process mathematically.\nStart {0}\nFinish {1}\nStep {2}", Start, Finish, Step));
            StringBuilder sb = new StringBuilder();
            if (Start > Finish)
            {
                for (int i = Start; i > Finish; i += Step)
                {
                    sb.AppendLine(_GetValue(i));
                }
            }
            else
            {
                for (int i = Start; i < Finish; i += Step)
                {
                    sb.AppendLine(_GetValue(i));
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// Creates the output string based upon provided criterion, including Dividends collection, incrementing by +1.
        /// </summary>
        /// <param name="Start">int; The number to begin counting at</param>
        /// <param name="Finish">int; the number to end counting at</param>
        /// <returns>string</returns>
        public string GetOutput(int Start, int Finish)
        {
            return GetOutput(Start, Finish, 1);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Creates the correct output based upon the Dividends collection.
        /// </summary>
        /// <param name="Divisor">int; the number to evaluate</param>
        /// <returns>string</returns>
        private string _GetValue(int Divisor)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, string> kvp in Dividends)
            {
                if (Divisor % kvp.Key == 0)
                    sb.Append(kvp.Value);
            }
            if (sb.Length < 1) sb.Append(Divisor.ToString());
            return sb.ToString();
        }

        #endregion

    }
}
