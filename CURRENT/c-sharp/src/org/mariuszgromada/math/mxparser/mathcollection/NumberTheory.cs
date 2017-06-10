/*
 * @(#)NumberTheory.cs        4.1.0    2017-06-09
 *
 * You may use this software under the condition of "Simplified BSD License"
 *
 * Copyright 2010-2017 MARIUSZ GROMADA. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are
 * permitted provided that the following conditions are met:
 *
 *    1. Redistributions of source code must retain the above copyright notice, this list of
 *       conditions and the following disclaimer.
 *
 *    2. Redistributions in binary form must reproduce the above copyright notice, this list
 *       of conditions and the following disclaimer in the documentation and/or other materials
 *       provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY <MARIUSZ GROMADA> ``AS IS'' AND ANY EXPRESS OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
 * ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * The views and conclusions contained in the software and documentation are those of the
 * authors and should not be interpreted as representing official policies, either expressed
 * or implied, of MARIUSZ GROMADA.
 *
 * If you have any questions/bugs feel free to contact:
 *
 *     Mariusz Gromada
 *     mariuszgromada.org@gmail.com
 *     http://mathparser.org
 *     http://mathspace.pl
 *     http://janetsudoku.mariuszgromada.org
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *     http://mariuszgromada.github.io/MathParser.org-mXparser
 *     http://mxparser.sourceforge.net
 *     http://bitbucket.org/mariuszgromada/mxparser
 *     http://mxparser.codeplex.com
 *     http://github.com/mariuszgromada/Janet-Sudoku
 *     http://janetsudoku.codeplex.com
 *     http://sourceforge.net/projects/janetsudoku
 *     http://bitbucket.org/mariuszgromada/janet-sudoku
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *
 *                              Asked if he believes in one God, a mathematician answered:
 *                              "Yes, up to isomorphism."
 */
using org.mariuszgromada.math.mxparser.parsertokens;
using System;

namespace org.mariuszgromada.math.mxparser.mathcollection {
	/**
	 * NumberTheory - summation / products etc...
	 *
	 * @author         <b>Mariusz Gromada</b><br>
	 *                 <a href="mailto:mariuszgromada.org@gmail.com">mariuszgromada.org@gmail.com</a><br>
	 *                 <a href="http://mathspace.pl" target="_blank">MathSpace.pl</a><br>
	 *                 <a href="http://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser on GitHub</a><br>
	 *                 <a href="http://mxparser.sourceforge.net" target="_blank">mXparser on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/mxparser" target="_blank">mXparser on Bitbucket</a><br>
	 *                 <a href="http://mxparser.codeplex.com" target="_blank">mXparser on CodePlex</a><br>
	 *                 <a href="http://janetsudoku.mariuszgromada.org" target="_blank">Janet Sudoku - project web page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/Janet-Sudoku" target="_blank">Janet Sudoku on GitHub</a><br>
	 *                 <a href="http://janetsudoku.codeplex.com" target="_blank">Janet Sudoku on CodePlex</a><br>
	 *                 <a href="http://sourceforge.net/projects/janetsudoku" target="_blank">Janet Sudoku on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/janet-sudoku" target="_blank">Janet Sudoku on BitBucket</a><br>
	 *
	 * @version        4.1.0
	 */
	[CLSCompliant(true)]
	public sealed class NumberTheory {
		/**
		 * Minimum function.
		 *
		 * @param      a                   the a function parameter
		 * @param      b                   the b function parameter
		 *
		 * @return     if a,b <> Double.NaN returns Math.min(a, b),
		 *             otherwise returns Double.NaN.
		 */
		public static double min(double a, double b) {
			if (Double.IsNaN(a) || Double.IsNaN(b))
				return Double.NaN;
			return Math.Min(a, b);
		}
		/**
		 * Minimum function.
		 *
		 * @param      numbers             the a function parameter
		 *
		 * @return     if each number form numbers <> Double.NaN returns the smallest number,
		 *             otherwise returns Double.NaN.
		 */
		public static double min(params double[] numbers) {
			double min = Double.PositiveInfinity;
			foreach (double number in numbers) {
				if (Double.IsNaN(number))
					return Double.NaN;
				if (number < min)
					min = number;
			}
			return min;
		}
		/**
		 * Maximum function.
		 *
		 * @param      a                   the a function parameter
		 * @param      b                   the b function parameter
		 *
		 * @return     if a,b <> Double.NaN returns Math.max(a, b),
		 *             otherwise returns Double.NaN.
		 */
		public static double max(double a, double b) {
			if (Double.IsNaN(a) || Double.IsNaN(b))
				return Double.NaN;
			return Math.Max(a, b);
		}
		/**
		 * Maximum function.
		 *
		 * @param      numbers             the a function parameter
		 *
		 * @return     if each number form numbers <> Double.NaN returns the highest number,
		 *             otherwise returns Double.NaN.
		 */
		public static double max(params double[] numbers) {
			double max = Double.NegativeInfinity;
			foreach (double number in numbers) {
				if (Double.IsNaN(number))
					return Double.NaN;
				if (number > max)
					max = number;
			}
			return max;
		}
		/**
		 * Greatest common divisor (GCD)
		 *
		 * @param      a                   the a function parameter
		 * @param      b                   the b function parameter
		 * @return     GCD(a,b)
		 */
		public static double gcd(int a, int b) {
			a = Math.Abs(a);
			b = Math.Abs(b);
			if (a == 0)
				return b;
			while (b != 0)
				if (a > b)
					a -= b;
				else
					b -= a;
			return a;
		}
		/**
		 * Greatest common divisor (GCD)
		 *
		 * @param      a                   the a function parameter
		 * @param      b                   the b function parameter
		 *
		 * @return     if a, b <> Double.NaN returns gcd( (int)Math.round(a),(int)Math.round(b) ),
		 *             otherwise returns Double.NaN.
		 */
		public static double gcd(double a, double b) {
			if (Double.IsNaN(a) || Double.IsNaN(a))
				return Double.NaN;
			return gcd((int)Math.Round(a), (int)Math.Round(b));
		}
		/**
		 * Greatest common divisor (GCD)
		 *
		 * @param      numbers             the numbers
		 *
		 * @return     GCD(a_1,...,a_n) a_1,...,a_n in numbers
		 */
		public static double gcd(params int[] numbers) {
			if (numbers.Length == 1)
				return numbers[0];
			if (numbers.Length == 2)
				return gcd(numbers[0], numbers[1]);
			for (int i = 1; i < numbers.Length; i++)
				numbers[i] = (int)gcd(numbers[i - 1], numbers[i]);
			return numbers[numbers.Length - 1];
		}
		/**
		 * Greatest common divisor (GCD)
		 *
		 * @param      numbers             the numbers
		 *
		 * @return     if each number form numbers <> Double.NaN returns
		 *             GCD(a_1,...,a_n) a_1,...,a_n in numbers,
		 *             otherwise returns Double.NaN.
		 */
		public static double gcd(params double[] numbers) {
			int[] intNumbers = new int[numbers.Length];
			for (int i = 0; i < numbers.Length; i++) {
				double n = numbers[i];
				if (Double.IsNaN(n))
					return Double.NaN;
				intNumbers[i] = (int)Math.Round(n);
			}
			return gcd(intNumbers);
		}
		/**
		 * Latest common multiply (LCM)
		 *
		 * @param      a                   the a function parameter
		 * @param      b                   the b function parameter
		 *
		 * @return     LCM(a,b)
		 */
		public static double lcm(int a, int b) {
			if ((a == 0) || (b == 0))
				return 0;
			return Math.Abs(a * b) / gcd(a, b);
		}
		/**
		 * Latest common multiply (LCM)
		 *
		 * @param      a                   the a function parameter
		 * @param      b                   the b function parameter
		 *
		 * @return     if a, b <> Double.NaN returns lcm( (int)Math.round(a), (int)Math.round(b) ),
		 *             otherwise returns Double.NaN.
		 */
		public static double lcm(double a, double b) {
			if (Double.IsNaN(a) || Double.IsNaN(a))
				return Double.NaN;
			return lcm((int)Math.Round(a), (int)Math.Round(b));
		}
		/**
		 * Latest common multiply (LCM)
		 *
		 * @param      numbers             the numbers
		 *
		 * @return     LCM(a_1,...,a_n) a_1,...,a_n in numbers
		 */
		public static double lcm(params int[] numbers) {
			if (numbers.Length == 1)
				return numbers[0];
			if (numbers.Length == 2)
				return lcm(numbers[0], numbers[1]);
			for (int i = 1; i < numbers.Length; i++)
				numbers[i] = (int)lcm(numbers[i - 1], numbers[i]);
			return numbers[numbers.Length - 1];
		}
		/**
		 * Latest common multiply (LCM)
		 *
		 * @param      numbers             the numbers
		 *
		 * @return     if each number form numbers <> Double.NaN returns
		 *             LCM(a_1,...,a_n) a_1,...,a_n in numbers,
		 *             otherwise returns Double.NaN.
		 */
		public static double lcm(params double[] numbers) {
			int[] intNumbers = new int[numbers.Length];
			for (int i = 0; i < numbers.Length; i++) {
				double n = numbers[i];
				if (Double.IsNaN(n))
					return Double.NaN;
				intNumbers[i] = (int)Math.Round(n);
				if (intNumbers[i] == 0)
					return 0;
			}
			return lcm(intNumbers);
		}
		/**
		 * Adding numbers.
		 *
		 * @param      numbers             the numbers
		 *
		 * @return     if each number from numbers <> Double.NaN returns
		 *             sum(a_1,...,a_n) a_1,...,a_n in numbers,
		 *             otherwise returns Double.NaN.
		 */
		public static double sum(params double[] numbers) {
			if (numbers.Length == 0) return Double.NaN;
			if (numbers.Length == 1) return numbers[0];
			double sum = 0;
			foreach (double xi in numbers) {
				if (Double.IsNaN(xi))
					return Double.NaN;
				sum += xi;
			}
			return sum;
		}
		/**
		 * Numbers multiplication.
		 *
		 * @param      numbers             the numbers
		 *
		 * @return     if each number from numbers <> Double.NaN returns
		 *             prod(a_1,...,a_n) a_1,...,a_n in numbers,
		 *             otherwise returns Double.NaN.
		 */
		public static double prod(params double[] numbers) {
			if (numbers.Length == 0) return Double.NaN;
			if (numbers.Length == 1) return numbers[0];
			double prod = 1;
			foreach (double xi in numbers) {
				if (Double.IsNaN(xi))
					return Double.NaN;
				prod *= xi;
			}
			return prod;
		}
		/**
		 * Prime test
		 *
		 * @param n
		 *
		 * @return true if number is prime, otherwise false
		 */
		public static bool primeTest(long n) {
			/*
			 * 2 is a prime :-)
			 */
			if (n == 2) return true;
			/*
			 * Even number is not a prime
			 */
			if (n % 2 == 0) return false;
			/*
			 * Everything <= 1 is not a prime
			 */
			if (n <= 1) return false;
			/*
			 * Will be searching for divisors till sqrt(n)
			 */
			long top = (long)Math.Sqrt(n);
			/*
			 * Supporting variable indicating odd end of primes cache
			 */
			long primesCacheOddEnd = 3;
			/*
			 * If prime cache exist
			 */
			if (mXparser.primesCache != null)
				if (mXparser.primesCache.cacheStatus == PrimesCache.CACHING_FINISHED) {
					/*
					 * If prime cache is ready and number we are querying
					 * is in cache the cache answer will be returned
					 */
					if (n <= mXparser.primesCache.maxNumInCache)
						return mXparser.primesCache.isPrime[(int)n];
					else {
						/*
						 * If number is bigger than maximum stored in cache
						 * the we are querying each prime in cache
						 * and checking if it is a divisor of n
						 */
						long topCache = Math.Min(top, mXparser.primesCache.maxNumInCache);
						long i;
						for (i = 3; i <= topCache; i += 2) {
							if (mXparser.primesCache.isPrime[(int)i] == true)
								if (n % i == 0) return false;
						}
						/*
						 * If no prime divisor of n in primes cache
						 * we are seting the odd end of prime cache
						 */
						primesCacheOddEnd = i;
					}
				}
			/*
			 * Finally we are checking any odd number that
			 * still left and is below sqrt(n) agains being
			 * divisor of n
			 */
			for (long i = primesCacheOddEnd; i <= top; i += 2)
				if (n % i == 0) return false;
			return true;
		}
		/**
		 * Prime test
		 *
		 * @param n
		 *
		 * @return true if number is prime, otherwise false
		 */
		public static double primeTest(double n) {
			if (Double.IsNaN(n)) return Double.NaN;
			bool isPrime = primeTest((long)n);
			if (isPrime == true)
				return 1;
			else
				return 0;
		}
		/**
		 * Prime counting function
		 *
		 * @param n number
		 *
		 * @return Number of primes below or equal x
		 */
		public static long primeCount(long n) {
			if (n <= 1) return 0;
			if (n == 2) return 1;
			long numberOfPrimes = 1;
			for (long i = 3; i <= n; i++)
				if (primeTest(i) == true)
					numberOfPrimes++;
			return numberOfPrimes;
		}
		/**
		 * Prime counting function
		 *
		 * @param n number
		 *
		 * @return Number of primes below or equal x
		 */
		public static double primeCount(double n) {
			return primeCount((long)n);
		}
		/**
		 * Summation operator (SIGMA FROM i = a, to b,  f(i) by delta
		 *
		 * @param      f                   the expression
		 * @param      index               the name of index argument
		 * @param      from                FROM index = form
		 * @param      to                  TO index = to
		 * @param      delta               BY delta
		 *
		 * @return     summation operation (for empty summation operations returns 0).
		 */
		public static double sigmaSummation(Expression f, Argument index, double from, double to, double delta) {
			double result = 0;
			if ((Double.IsNaN(delta)) || (Double.IsNaN(from)) || (Double.IsNaN(to)) || (delta == 0))
				return Double.NaN;
			if ((to >= from) && (delta > 0)) {
				double i;
				for (i = from; i < to; i += delta)
					result += mXparser.getFunctionValue(f, index, i);
				if (delta - (i - to) > 0.5 * delta) result += mXparser.getFunctionValue(f, index, to);
			} else if ((to <= from) && (delta < 0)) {
				double i;
				for (i = from; i > to; i += delta)
					result += mXparser.getFunctionValue(f, index, i);
				if (delta - (to - i) > 0.5 * delta) result += mXparser.getFunctionValue(f, index, to);
			} else if (from == to)
				result += mXparser.getFunctionValue(f, index, from);
			return result;
		}
		/**
		 * Product operator
		 *
		 * @param      f                   the expression
		 * @param      index               the name of index argument
		 * @param      from                FROM index = form
		 * @param      to                  TO index = to
		 * @param      delta               BY delta
		 *
		 * @return     product operation (for empty product operations returns 1).
		 *
		 * @see        Expression
		 * @see        Argument
		 */
		public static double piProduct(Expression f, Argument index, double from, double to, double delta) {
			if ((Double.IsNaN(delta)) || (Double.IsNaN(from)) || (Double.IsNaN(to)) || (delta == 0))
				return Double.NaN;
			double result = 1;
			if ((to >= from) && (delta > 0)) {
				double i;
				for (i = from; i < to; i += delta)
					result *= mXparser.getFunctionValue(f, index, i);
				if (delta - (i - to) > 0.5 * delta) result *= mXparser.getFunctionValue(f, index, to);
			} else if ((to <= from) && (delta < 0)) {
				double i;
				for (i = from; i > to; i += delta)
					result *= mXparser.getFunctionValue(f, index, i);
				if (delta - (to - i) > 0.5 * delta) result *= mXparser.getFunctionValue(f, index, to);
			} else if (from == to)
				result *= mXparser.getFunctionValue(f, index, from);
			return result;
		}
		/**
		 * Minimum value - iterative operator.
		 *
		 * @param      f                   the expression
		 * @param      index               the name of index argument
		 * @param      from                FROM index = form
		 * @param      to                  TO index = to
		 * @param      delta               BY delta
		 *
		 * @return     product operation (for empty product operations returns 1).
		 *
		 * @see        Expression
		 * @see        Argument
		 */
		public static double min(Expression f, Argument index, double from, double to, double delta) {
			if ((Double.IsNaN(delta)) || (Double.IsNaN(from)) || (Double.IsNaN(to)) || (delta == 0))
				return Double.NaN;
			double min = Double.PositiveInfinity;
			double v;
			if ((to >= from) && (delta > 0)) {
				for (double i = from; i < to; i += delta) {
					v = mXparser.getFunctionValue(f, index, i);
					if (v < min) min = v;
				}
				v = mXparser.getFunctionValue(f, index, to);
				if (v < min) min = v;
			} else if ((to <= from) && (delta < 0)) {
				for (double i = from; i > to; i += delta) {
					v = mXparser.getFunctionValue(f, index, i);
					if (v < min) min = v;
				}
				v = mXparser.getFunctionValue(f, index, to);
				if (v < min) min = v;
			} else if (from == to)
				min = mXparser.getFunctionValue(f, index, from);
			return min;
		}
		/**
		 * Maximum value - iterative operator.
		 *
		 * @param      f                   the expression
		 * @param      index               the name of index argument
		 * @param      from                FROM index = form
		 * @param      to                  TO index = to
		 * @param      delta               BY delta
		 *
		 * @return     product operation (for empty product operations returns 1).
		 *
		 * @see        Expression
		 * @see        Argument
		 */
		public static double max(Expression f, Argument index, double from, double to, double delta) {
			if ((Double.IsNaN(delta)) || (Double.IsNaN(from)) || (Double.IsNaN(to)) || (delta == 0))
				return Double.NaN;
			double max = Double.NegativeInfinity;
			double v;
			if ((to >= from) && (delta > 0)) {
				for (double i = from; i < to; i += delta) {
					v = mXparser.getFunctionValue(f, index, i);
					if (v > max) max = v;
				}
				v = mXparser.getFunctionValue(f, index, to);
				if (v > max) max = v;
			} else if ((to <= from) && (delta < 0)) {
				for (double i = from; i > to; i += delta) {
					v = mXparser.getFunctionValue(f, index, i);
					if (v > max) max = v;
				}
				v = mXparser.getFunctionValue(f, index, to);
				if (v > max) max = v;
			} else if (from == to)
				max = mXparser.getFunctionValue(f, index, from);
			return max;
		}
		/**
		 * Return regular expression representing number literal
		 * string in given numeral system with base between 1 and 36.
		 *
		 * @param numeralSystemBase    Base of numeral system, base between 1 and 36
		 * @return        Regular expression string if base between 1 and 36,
		 *                otherwise empty string "" is returned.
		 */
		private static String getRegExpForNumeralSystem(int numeralSystemBase) {
			switch (numeralSystemBase) {
				case 1: return ParserSymbol.BASE1_REG_EXP;
				case 2: return ParserSymbol.BASE2_REG_EXP;
				case 3: return ParserSymbol.BASE3_REG_EXP;
				case 4: return ParserSymbol.BASE4_REG_EXP;
				case 5: return ParserSymbol.BASE5_REG_EXP;
				case 6: return ParserSymbol.BASE6_REG_EXP;
				case 7: return ParserSymbol.BASE7_REG_EXP;
				case 8: return ParserSymbol.BASE8_REG_EXP;
				case 9: return ParserSymbol.BASE9_REG_EXP;
				case 10: return ParserSymbol.BASE10_REG_EXP;
				case 11: return ParserSymbol.BASE11_REG_EXP;
				case 12: return ParserSymbol.BASE12_REG_EXP;
				case 13: return ParserSymbol.BASE13_REG_EXP;
				case 14: return ParserSymbol.BASE14_REG_EXP;
				case 15: return ParserSymbol.BASE15_REG_EXP;
				case 16: return ParserSymbol.BASE16_REG_EXP;
				case 17: return ParserSymbol.BASE17_REG_EXP;
				case 18: return ParserSymbol.BASE18_REG_EXP;
				case 19: return ParserSymbol.BASE19_REG_EXP;
				case 20: return ParserSymbol.BASE20_REG_EXP;
				case 21: return ParserSymbol.BASE21_REG_EXP;
				case 22: return ParserSymbol.BASE22_REG_EXP;
				case 23: return ParserSymbol.BASE23_REG_EXP;
				case 24: return ParserSymbol.BASE24_REG_EXP;
				case 25: return ParserSymbol.BASE25_REG_EXP;
				case 26: return ParserSymbol.BASE26_REG_EXP;
				case 27: return ParserSymbol.BASE27_REG_EXP;
				case 28: return ParserSymbol.BASE28_REG_EXP;
				case 29: return ParserSymbol.BASE29_REG_EXP;
				case 30: return ParserSymbol.BASE30_REG_EXP;
				case 31: return ParserSymbol.BASE31_REG_EXP;
				case 32: return ParserSymbol.BASE32_REG_EXP;
				case 33: return ParserSymbol.BASE33_REG_EXP;
				case 34: return ParserSymbol.BASE34_REG_EXP;
				case 35: return ParserSymbol.BASE35_REG_EXP;
				case 36: return ParserSymbol.BASE36_REG_EXP;
			}
			/* reg exp that does not match anything */
			return "\\b\\B";
		}
		/**
		 * Digit index based on digit character for numeral systems with
		 * base between 1 and 36.
		 *
		 * @param digitChar   Digit character (lower or upper case) representing digit in numeral
		 *                    systems with base between 1 and 36. Digits:
		 *                    0:0, 1:1, 2:2, 3:3, 4:4, 5:5, 6:6, 7:7, 8:8,
		 *                    9:9, 10:A, 11:B, 12:C, 13:D, 14:E, 15:F, 16:G,
		 *                    17:H, 18:I, 19:J, 20:K, 21:L, 22:M, 23:N, 24:O,
		 *                    25:P, 26:Q, 27:R, 28:S, 29:T, 30:U, 31:V, 32:W,
		 *                    33:X, 34:Y, 35:Z
		 * @return            Returns digit index if digit char was recognized,
		 *                    otherwise returns -1.
		 */
		public static int digitIndex(char digitChar) {
			switch (digitChar) {
				case '0': return 0;
				case '1': return 1;
				case '2': return 2;
				case '3': return 3;
				case '4': return 4;
				case '5': return 5;
				case '6': return 6;
				case '7': return 7;
				case '8': return 8;
				case '9': return 9;
				case 'A': return 10;
				case 'B': return 11;
				case 'C': return 12;
				case 'D': return 13;
				case 'E': return 14;
				case 'F': return 15;
				case 'G': return 16;
				case 'H': return 17;
				case 'I': return 18;
				case 'J': return 19;
				case 'K': return 20;
				case 'L': return 21;
				case 'M': return 22;
				case 'N': return 23;
				case 'O': return 24;
				case 'P': return 25;
				case 'Q': return 26;
				case 'R': return 27;
				case 'S': return 28;
				case 'T': return 29;
				case 'U': return 30;
				case 'V': return 31;
				case 'W': return 32;
				case 'X': return 33;
				case 'Y': return 34;
				case 'Z': return 35;
				case 'a': return 10;
				case 'b': return 11;
				case 'c': return 12;
				case 'd': return 13;
				case 'e': return 14;
				case 'f': return 15;
				case 'g': return 16;
				case 'h': return 17;
				case 'i': return 18;
				case 'j': return 19;
				case 'k': return 20;
				case 'l': return 21;
				case 'm': return 22;
				case 'n': return 23;
				case 'o': return 24;
				case 'p': return 25;
				case 'q': return 26;
				case 'r': return 27;
				case 's': return 28;
				case 't': return 29;
				case 'u': return 30;
				case 'v': return 31;
				case 'w': return 32;
				case 'x': return 33;
				case 'y': return 34;
				case 'z': return 35;
			}
			return -1;
		}
		/**
		 * Character representing digit for numeral systems with base
		 * between 1 and 36.
		 *
		 * @param digitIndex   Digit index between 0 and 35
		 * @return             Digit character representing digit
		 *                     for numeral systems with base between 1 and 36.
		 *                     Digits: 0:0, 1:1, 2:2, 3:3, 4:4, 5:5, 6:6, 7:7,
		 *                     8:8, 9:9, 10:A, 11:B, 12:C, 13:D, 14:E, 15:F,
		 *                     16:G, 17:H, 18:I, 19:J, 20:K, 21:L, 22:M, 23:N,
		 *                     24:O, 25:P, 26:Q, 27:R, 28:S, 29:T, 30:U, 31:V,
		 *                     32:W, 33:X, 34:Y, 35:Z. If digit index is put of range
		 *                     '?' is returned.
		 */
		public static char digitChar(int digitIndex) {
			switch (digitIndex) {
				case 0: return '0';
				case 1: return '1';
				case 2: return '2';
				case 3: return '3';
				case 4: return '4';
				case 5: return '5';
				case 6: return '6';
				case 7: return '7';
				case 8: return '8';
				case 9: return '9';
				case 10: return 'A';
				case 11: return 'B';
				case 12: return 'C';
				case 13: return 'D';
				case 14: return 'E';
				case 15: return 'F';
				case 16: return 'G';
				case 17: return 'H';
				case 18: return 'I';
				case 19: return 'J';
				case 20: return 'K';
				case 21: return 'L';
				case 22: return 'M';
				case 23: return 'N';
				case 24: return 'O';
				case 25: return 'P';
				case 26: return 'Q';
				case 27: return 'R';
				case 28: return 'S';
				case 29: return 'T';
				case 30: return 'U';
				case 31: return 'V';
				case 32: return 'W';
				case 33: return 'X';
				case 34: return 'Y';
				case 35: return 'Z';
			}
			return '?';
		}
		/**
		 * Recognition of numeral system base in which number literal represents
		 * number.
		 * Examples: 2 for b2.1001 or b.1001, 1 for b1.111, 23 for b23.123afg
		 * 16 for b16.123acdf or h.123acdf.
		 *
		 * @param numberLiteral Number literal string.
		 *
		 * Base format: b1. b2. b. b3. b4. b5. b6. b7. b8. o. b9. b10. b11. b12.
		 * b13. b14. b15. b16. h. b17. b18. b19. b20. b21. b22. b23. b24. b25. b26.
		 * b27. b28. b29. b30. b31. b32. b33. b34. b35. b36.
		 *
		 * Digits: 0:0, 1:1, 2:2, 3:3, 4:4, 5:5, 6:6, 7:7, 8:8, 9:9, 10:A, 11:B, 12:C,
		 * 13:D, 14:E, 15:F, 16:G, 17:H, 18:I, 19:J, 20:K, 21:L, 22:M, 23:N, 24:O, 25:P,
		 * 26:Q, 27:R, 28:S, 29:T, 30:U, 31:V, 32:W, 33:X, 34:Y, 35:Z
		 *
		 * @return  If number literal fits numeral system definition then numeral
		 *          system base is returned (base between 1 and 36), otherwise
		 *          -1 is returned.
		 */
		public static int getNumeralSystemBase(String numberLiteral) {
			for (int b = 0; b <= 36; b++)
				if (mXparser.regexMatch(numberLiteral, getRegExpForNumeralSystem(b)))
					return b;
			return -1;
		}
		/**
		 * Other base (base between 1 and 36) number literal conversion to decimal number.
		 *
		 * @param numberLiteral    Number literal in given numeral system with base between
		 *                         1 and 36. Digits: 0:0, 1:1, 2:2, 3:3, 4:4, 5:5, 6:6, 7:7,
		 *                         8:8, 9:9, 10:A, 11:B, 12:C, 13:D, 14:E, 15:F, 16:G, 17:H,
		 *                         18:I, 19:J, 20:K, 21:L, 22:M, 23:N, 24:O, 25:P, 26:Q, 27:R,
		 *                         28:S, 29:T, 30:U, 31:V, 32:W, 33:X, 34:Y, 35:Z
		 * @param numeralSystemBase             Numeral system base, between 1 and 36
		 * @return                 Decimal number after conversion. If conversion was not
		 *                         possible the Double.NaN is returned.
		 */
		public static double convOthBase2Decimal(String numberLiteral, int numeralSystemBase) {
			if (numberLiteral == null) return Double.NaN;
			numberLiteral = numberLiteral.Trim();
			if (numberLiteral.Length == 0) {
				if (numeralSystemBase == 1) return 0;
				else return Double.NaN;
			}
			if (numeralSystemBase < 1) return Double.NaN;
			if (numeralSystemBase > 36) return Double.NaN;
			char signChar = numberLiteral[0];
			double sign = 1.0;
			if (signChar == '-') {
				sign = -1.0;
				numberLiteral = numberLiteral.Substring(1);
			}
			else if (signChar == '+') {
				sign = 1.0;
				numberLiteral = numberLiteral.Substring(1);
			}
			int length = numberLiteral.Length;
			double decValue = 0;
			int digit;
			for (int i = 0; i < length; i++) {
				digit = digitIndex(numberLiteral[i]);
				if (numeralSystemBase > 1) {
					if ((digit >= 0) && (digit < numeralSystemBase)) decValue = numeralSystemBase * decValue + digit;
					else return Double.NaN;
				}
				else {
					if (digit == 1) decValue = numeralSystemBase * decValue + digit;
					else return Double.NaN;
				}
			}
			return sign * decValue;
		}
		/**
		 * Other base (base between 1 and 36) number literal conversion to decimal number.
		 * Base specification included in number literal.
		 *
		 * Examples: 2 for b2.1001 or b.1001, 1 for b1.111, 23 for b23.123afg
		 * 16 for b16.123acdf or h.123acdf.
		 *
		 * @param numberLiteral Number literal string.
		 *
		 * Base format: b1. b2. b. b3. b4. b5. b6. b7. b8. o. b9. b10. b11. b12.
		 * b13. b14. b15. b16. h. b17. b18. b19. b20. b21. b22. b23. b24. b25. b26.
		 * b27. b28. b29. b30. b31. b32. b33. b34. b35. b36.
		 *
		 * Digits: 0:0, 1:1, 2:2, 3:3, 4:4, 5:5, 6:6, 7:7, 8:8, 9:9, 10:A, 11:B, 12:C,
		 * 13:D, 14:E, 15:F, 16:G, 17:H, 18:I, 19:J, 20:K, 21:L, 22:M, 23:N, 24:O, 25:P,
		 * 26:Q, 27:R, 28:S, 29:T, 30:U, 31:V, 32:W, 33:X, 34:Y, 35:Z
		 *
		 * @return     Decimal number after conversion. If conversion was not
		 *             possible the Double.NaN is returned.
		 */
		public static double convOthBase2Decimal(String numberLiteral) {
			if (numberLiteral == null) return Double.NaN;
			numberLiteral = numberLiteral.Trim();
			int numberLiteralStrLenght = numberLiteral.Length;
			if (numberLiteralStrLenght < 2) return Double.NaN;
			int numeralSystemBase = getNumeralSystemBase(numberLiteral);
			if (numeralSystemBase == -1) return Double.NaN;
			/* find dot position */
			int dotPos = numberLiteral.IndexOf('.');
			if (dotPos == 0) return Double.NaN;
			char signChar = numberLiteral[0];
			double sign = 1.0;
			if (signChar == '-') sign = -1;
			String finalLiteral = "";
			if (numberLiteralStrLenght > dotPos + 1) finalLiteral = numberLiteral.Substring(dotPos + 1);
			return sign * convOthBase2Decimal(finalLiteral, numeralSystemBase);
		}
		/**
		 * Other base to decimal conversion.
		 *
		 * @param numeralSystemBase   Numeral system base has to be above 0.
		 * @param digits              List of digits
		 * @return                    Number after conversion. If conversion is not possible then
		 *                            Double.NaN is returned.
		 */
		public static double convOthBase2Decimal(int numeralSystemBase, params int[] digits) {
			if (numeralSystemBase < 1) return Double.NaN;
			if (digits == null) return Double.NaN;
			int length = digits.Length;
			if (length == 0) {
				if (numeralSystemBase == 1) return 0;
				else return Double.NaN;
			}
			double decValue = 0;
			int digit;
			for (int i = 0; i < length; i++) {
				digit = digits[i];
				if (numeralSystemBase > 1) {
					if ((digit >= 0) && (digit < numeralSystemBase)) decValue = numeralSystemBase * decValue + digit;
					else return Double.NaN;
				}
				else {
					if (digit == 1) decValue = numeralSystemBase * decValue + digit;
					else return Double.NaN;
				}
			}
			return decValue;
		}
		/**
		 * Other base to decimal conversion.
		 *
		 * @param numeralSystemBase   Numeral system base has to be above 0.
		 * @param digits              List of digits
		 * @return                    Number after conversion. If conversion is not possible then
		 *                            Double.NaN is returned.
		 */
		public static double convOthBase2Decimal(double numeralSystemBase, params double[] digits) {
			if (numeralSystemBase < 0) return Double.NaN;
			if (Double.IsNaN(numeralSystemBase)) return Double.NaN;
			int numeralSystemBaseInt = (int)MathFunctions.floor(numeralSystemBase);
			if (digits == null) return Double.NaN;
			int length = digits.Length;
			if (length == 0) {
				if (numeralSystemBaseInt == 1) return 0;
				else return Double.NaN;
			}
			int[] digitsInt = new int[length];
			double digit;
			for (int i = 0; i < length; i++) {
				digit = digits[i];
				if (Double.IsNaN(digit)) return Double.NaN;
				digitsInt[i] = (int)digit;
			}
			return convOthBase2Decimal(numeralSystemBaseInt, digitsInt);
		}
		/**
		 * Other base to decimal conversion.
		 *
		 * @param baseAndDigits   Numeral system base and digits specification.
		 *                        Numeral system base is placed at index 0, rest of
		 *                        array is interpreted as digits. Numeral system base
		 *                        has to be above 0.
		 * @return                Number after conversion. If conversion is not possible then
		 *                        Double.NaN is returned.
		 */
		public static double convOthBase2Decimal(int[] baseAndDigits) {
			if (baseAndDigits == null) return Double.NaN;
			if (baseAndDigits.Length == 0) return Double.NaN;
			int numeralSystemBase = baseAndDigits[0];
			int[] digits = new int[baseAndDigits.Length - 1];
			for (int i = 1; i < baseAndDigits.Length; i++)
				digits[i - 1] = baseAndDigits[i];
			return convOthBase2Decimal(numeralSystemBase, digits);
		}
		/**
		 * Other base to decimal conversion.
		 *
		 * @param baseAndDigits   Numeral system base and digits specification.
		 *                        Numeral system base is placed at index 0, rest of
		 *                        array is interpreted as digits. Numeral system base
		 *                        has to be above 0.
		 * @return                Number after conversion. If conversion is not possible then
		 *                        Double.NaN is returned.
		 */
		public static double convOthBase2Decimal(double[] baseAndDigits) {
			if (baseAndDigits == null) return Double.NaN;
			if (baseAndDigits.Length == 0) return Double.NaN;
			double numeralSystemBase = baseAndDigits[0];
			double[] digits = new double[baseAndDigits.Length - 1];
			for (int i = 1; i < baseAndDigits.Length; i++)
				digits[i - 1] = baseAndDigits[i];
			return convOthBase2Decimal(numeralSystemBase, digits);
		}
		/**
		 * Decimal number to other numeral system conversion with base
		 * between 1 and 36.
		 *
		 * @param decimalNumber    Decimal number
		 * @param numeralSystemBase       Numeral system base between 1 and 36
		 * @return           Number literal representing decimal number in
		 *                   given numeral numeral system. Digits
		 *                   0:0, 1:1, 2:2, 3:3, 4:4, 5:5, 6:6, 7:7, 8:8,
		 *                   9:9, 10:A, 11:B, 12:C, 13:D, 14:E, 15:F, 16:G,
		 *                   17:H, 18:I, 19:J, 20:K, 21:L, 22:M, 23:N, 24:O,
		 *                   25:P, 26:Q, 27:R, 28:S, 29:T, 30:U, 31:V, 32:W,
		 *                   33:X, 34:Y, 35:Z. If conversion was not possible
		 *                   the "NaN" string is returned.
		 */
		public static String convDecimal2OthBase(double decimalNumber, int numeralSystemBase) {
			if (Double.IsNaN(decimalNumber)) return "NaN";
			if (numeralSystemBase < 1) return "NaN";
			if (numeralSystemBase > 36) return "NaN";
			if (decimalNumber == 0.0) {
				if (numeralSystemBase > 1) return "0";
				else return "";
			}
			double intPart = MathFunctions.floor(MathFunctions.abs(decimalNumber));
			double sign = MathFunctions.sgn(decimalNumber);
			String signChar = "";
			if (sign < 0) signChar = "-";
			if (intPart < numeralSystemBase) return signChar + digitChar((int)intPart);
			String numberLiteral = "";
			double quotient = intPart;
			int reminder;
			if (numeralSystemBase > 1)
				while (quotient >= 1.0) {
					reminder = (int)(quotient % numeralSystemBase);
					quotient = MathFunctions.floor(quotient / numeralSystemBase);
					numberLiteral = digitChar(reminder) + numberLiteral;
				}
			else {
				char[] repeat = new char[(int)intPart];
				for (int i = 0; i < (int)intPart; i++)
					repeat[i] = '1';
				numberLiteral = new String(repeat);
			}
			return signChar + numberLiteral;
		}
		/**
		 * Decimal number to other numeral system conversion with base
		 * between 1 and 36.
		 *
		 * @param decimalNumber    Decimal number
		 * @param numeralSystemBase       Numeral system base between 1 and 36
		 * @param format     If 1 then always bxx. is used, i.e. b1. or b16.
		 *                   If 2 then for binary b. is used, for octal o. is used,
		 *                   for hexadecimal h. is used, otherwise bxx. is used
		 *                   where xx is the numeral system base specification.
		 *
		 * @return           Number literal representing decimal number in
		 *                   given numeral numeral system.
		 *
		 * Base format: b1. b2. b. b3. b4. b5. b6. b7. b8. o. b9. b10. b11. b12.
		 * b13. b14. b15. b16. h. b17. b18. b19. b20. b21. b22. b23. b24. b25. b26.
		 * b27. b28. b29. b30. b31. b32. b33. b34. b35. b36.
		 *
		 * Digits: 0:0, 1:1, 2:2, 3:3, 4:4, 5:5, 6:6, 7:7, 8:8, 9:9, 10:A, 11:B, 12:C,
		 * 13:D, 14:E, 15:F, 16:G, 17:H, 18:I, 19:J, 20:K, 21:L, 22:M, 23:N, 24:O, 25:P,
		 * 26:Q, 27:R, 28:S, 29:T, 30:U, 31:V, 32:W, 33:X, 34:Y, 35:Z
		 *
		 * If conversion was not possible the "NaN" string is returned.
		 */
		public static String convDecimal2OthBase(double decimalNumber, int numeralSystemBase, int format) {
			if (Double.IsNaN(decimalNumber)) return "NaN";
			if (numeralSystemBase < 1) return "NaN";
			if (numeralSystemBase > 36) return "NaN";
			String prefix = "";
			if ((format == 1) || (format == 2)) prefix = "b" + numeralSystemBase + ".";
			if (format == 2) {
				if (numeralSystemBase == 2) prefix = "b.";
				if (numeralSystemBase == 8) prefix = "o.";
				if (numeralSystemBase == 16) prefix = "h.";
			}
			String sign = "";
			if (decimalNumber < 0) sign = "-";
			return sign + prefix + convDecimal2OthBase(MathFunctions.abs(decimalNumber), numeralSystemBase);
		}
		/**
		 * Number of digits needed to represent given number in base 10 numeral system.
		 * @param number   The number
		 * @return         Number of digits needed to represent given number in base 10 numeral system.
		 */
		public static int numberOfDigits(long number) {
			if (number < 0) number = -number;
			if (number < 10) return 1;
			else if (number < 100) return 2;
			else if (number < 1000) return 3;
			else if (number < 10000) return 4;
			else if (number < 100000) return 5;
			else if (number < 1000000) return 6;
			else if (number < 10000000) return 7;
			else if (number < 100000000) return 8;
			else if (number < 1000000000) return 9;
			else return 10;
		}
		/**
		 * Number of digits needed to represent given number in base 10 numeral system.
		 * @param number   The number
		 * @return         Number of digits needed to represent given number in base 10 numeral system.
		 *                 If number is NaN the NaN is returned. If number is infinite then
		 *                 Double.POSITIVE_INFINITY is returned.
		 */
		public static double numberOfDigits(double number) {
			if (Double.IsNaN(number)) return Double.NaN;
			if (Double.IsInfinity(number)) return Double.PositiveInfinity;
			if (number < 0.0) number = -number;
			number = MathFunctions.floor(number);
			if (number < 1.0e1) return 1;
			else if (number < 1.0e2) return 2;
			else if (number < 1.0e3) return 3;
			else if (number < 1.0e4) return 4;
			else if (number < 1.0e5) return 5;
			else if (number < 1.0e6) return 6;
			else if (number < 1.0e7) return 7;
			else if (number < 1.0e8) return 8;
			else if (number < 1.0e9) return 9;
			else if (number < 1.0e10) return 10;
			else if (number < 1.0e11) return 11;
			else if (number < 1.0e12) return 12;
			else if (number < 1.0e13) return 13;
			else if (number < 1.0e14) return 14;
			else if (number < 1.0e15) return 15;
			else if (number < 1.0e16) return 16;
			else if (number < 1.0e17) return 17;
			else if (number < 1.0e18) return 18;
			else if (number < 1.0e19) return 19;
			else if (number < 1.0e20) return 20;
			else if (number < 1.0e21) return 21;
			else if (number < 1.0e22) return 22;
			else if (number < 1.0e23) return 23;
			else if (number < 1.0e24) return 24;
			else if (number < 1.0e25) return 25;
			else if (number < 1.0e26) return 26;
			else if (number < 1.0e27) return 27;
			else if (number < 1.0e28) return 28;
			else if (number < 1.0e29) return 29;
			else if (number < 1.0e30) return 30;
			else if (number < 1.0e31) return 31;
			else if (number < 1.0e32) return 32;
			else if (number < 1.0e33) return 33;
			else if (number < 1.0e34) return 34;
			else if (number < 1.0e35) return 35;
			else if (number < 1.0e36) return 36;
			else if (number < 1.0e37) return 37;
			else if (number < 1.0e38) return 38;
			else if (number < 1.0e39) return 39;
			else if (number < 1.0e40) return 40;
			else if (number < 1.0e41) return 41;
			else if (number < 1.0e42) return 42;
			else if (number < 1.0e43) return 43;
			else if (number < 1.0e44) return 44;
			else if (number < 1.0e45) return 45;
			else if (number < 1.0e46) return 46;
			else if (number < 1.0e47) return 47;
			else if (number < 1.0e48) return 48;
			else if (number < 1.0e49) return 49;
			else if (number < 1.0e50) return 50;
			else if (number < 1.0e51) return 51;
			else if (number < 1.0e52) return 52;
			else if (number < 1.0e53) return 53;
			else if (number < 1.0e54) return 54;
			else if (number < 1.0e55) return 55;
			else if (number < 1.0e56) return 56;
			else if (number < 1.0e57) return 57;
			else if (number < 1.0e58) return 58;
			else if (number < 1.0e59) return 59;
			else if (number < 1.0e60) return 60;
			else if (number < 1.0e61) return 61;
			else if (number < 1.0e62) return 62;
			else if (number < 1.0e63) return 63;
			else if (number < 1.0e64) return 64;
			else if (number < 1.0e65) return 65;
			else if (number < 1.0e66) return 66;
			else if (number < 1.0e67) return 67;
			else if (number < 1.0e68) return 68;
			else if (number < 1.0e69) return 69;
			else if (number < 1.0e70) return 70;
			else if (number < 1.0e71) return 71;
			else if (number < 1.0e72) return 72;
			else if (number < 1.0e73) return 73;
			else if (number < 1.0e74) return 74;
			else if (number < 1.0e75) return 75;
			else if (number < 1.0e76) return 76;
			else if (number < 1.0e77) return 77;
			else if (number < 1.0e78) return 78;
			else if (number < 1.0e79) return 79;
			else if (number < 1.0e80) return 80;
			else if (number < 1.0e81) return 81;
			else if (number < 1.0e82) return 82;
			else if (number < 1.0e83) return 83;
			else if (number < 1.0e84) return 84;
			else if (number < 1.0e85) return 85;
			else if (number < 1.0e86) return 86;
			else if (number < 1.0e87) return 87;
			else if (number < 1.0e88) return 88;
			else if (number < 1.0e89) return 89;
			else if (number < 1.0e90) return 90;
			else if (number < 1.0e91) return 91;
			else if (number < 1.0e92) return 92;
			else if (number < 1.0e93) return 93;
			else if (number < 1.0e94) return 94;
			else if (number < 1.0e95) return 95;
			else if (number < 1.0e96) return 96;
			else if (number < 1.0e97) return 97;
			else if (number < 1.0e98) return 98;
			else if (number < 1.0e99) return 99;
			else if (number < 1.0e100) return 100;
			else if (number < 1.0e101) return 101;
			else if (number < 1.0e102) return 102;
			else if (number < 1.0e103) return 103;
			else if (number < 1.0e104) return 104;
			else if (number < 1.0e105) return 105;
			else if (number < 1.0e106) return 106;
			else if (number < 1.0e107) return 107;
			else if (number < 1.0e108) return 108;
			else if (number < 1.0e109) return 109;
			else if (number < 1.0e110) return 110;
			else if (number < 1.0e111) return 111;
			else if (number < 1.0e112) return 112;
			else if (number < 1.0e113) return 113;
			else if (number < 1.0e114) return 114;
			else if (number < 1.0e115) return 115;
			else if (number < 1.0e116) return 116;
			else if (number < 1.0e117) return 117;
			else if (number < 1.0e118) return 118;
			else if (number < 1.0e119) return 119;
			else if (number < 1.0e120) return 120;
			else if (number < 1.0e121) return 121;
			else if (number < 1.0e122) return 122;
			else if (number < 1.0e123) return 123;
			else if (number < 1.0e124) return 124;
			else if (number < 1.0e125) return 125;
			else if (number < 1.0e126) return 126;
			else if (number < 1.0e127) return 127;
			else if (number < 1.0e128) return 128;
			else if (number < 1.0e129) return 129;
			else if (number < 1.0e130) return 130;
			else if (number < 1.0e131) return 131;
			else if (number < 1.0e132) return 132;
			else if (number < 1.0e133) return 133;
			else if (number < 1.0e134) return 134;
			else if (number < 1.0e135) return 135;
			else if (number < 1.0e136) return 136;
			else if (number < 1.0e137) return 137;
			else if (number < 1.0e138) return 138;
			else if (number < 1.0e139) return 139;
			else if (number < 1.0e140) return 140;
			else if (number < 1.0e141) return 141;
			else if (number < 1.0e142) return 142;
			else if (number < 1.0e143) return 143;
			else if (number < 1.0e144) return 144;
			else if (number < 1.0e145) return 145;
			else if (number < 1.0e146) return 146;
			else if (number < 1.0e147) return 147;
			else if (number < 1.0e148) return 148;
			else if (number < 1.0e149) return 149;
			else if (number < 1.0e150) return 150;
			else if (number < 1.0e151) return 151;
			else if (number < 1.0e152) return 152;
			else if (number < 1.0e153) return 153;
			else if (number < 1.0e154) return 154;
			else if (number < 1.0e155) return 155;
			else if (number < 1.0e156) return 156;
			else if (number < 1.0e157) return 157;
			else if (number < 1.0e158) return 158;
			else if (number < 1.0e159) return 159;
			else if (number < 1.0e160) return 160;
			else if (number < 1.0e161) return 161;
			else if (number < 1.0e162) return 162;
			else if (number < 1.0e163) return 163;
			else if (number < 1.0e164) return 164;
			else if (number < 1.0e165) return 165;
			else if (number < 1.0e166) return 166;
			else if (number < 1.0e167) return 167;
			else if (number < 1.0e168) return 168;
			else if (number < 1.0e169) return 169;
			else if (number < 1.0e170) return 170;
			else if (number < 1.0e171) return 171;
			else if (number < 1.0e172) return 172;
			else if (number < 1.0e173) return 173;
			else if (number < 1.0e174) return 174;
			else if (number < 1.0e175) return 175;
			else if (number < 1.0e176) return 176;
			else if (number < 1.0e177) return 177;
			else if (number < 1.0e178) return 178;
			else if (number < 1.0e179) return 179;
			else if (number < 1.0e180) return 180;
			else if (number < 1.0e181) return 181;
			else if (number < 1.0e182) return 182;
			else if (number < 1.0e183) return 183;
			else if (number < 1.0e184) return 184;
			else if (number < 1.0e185) return 185;
			else if (number < 1.0e186) return 186;
			else if (number < 1.0e187) return 187;
			else if (number < 1.0e188) return 188;
			else if (number < 1.0e189) return 189;
			else if (number < 1.0e190) return 190;
			else if (number < 1.0e191) return 191;
			else if (number < 1.0e192) return 192;
			else if (number < 1.0e193) return 193;
			else if (number < 1.0e194) return 194;
			else if (number < 1.0e195) return 195;
			else if (number < 1.0e196) return 196;
			else if (number < 1.0e197) return 197;
			else if (number < 1.0e198) return 198;
			else if (number < 1.0e199) return 199;
			else if (number < 1.0e200) return 200;
			else if (number < 1.0e201) return 201;
			else if (number < 1.0e202) return 202;
			else if (number < 1.0e203) return 203;
			else if (number < 1.0e204) return 204;
			else if (number < 1.0e205) return 205;
			else if (number < 1.0e206) return 206;
			else if (number < 1.0e207) return 207;
			else if (number < 1.0e208) return 208;
			else if (number < 1.0e209) return 209;
			else if (number < 1.0e210) return 210;
			else if (number < 1.0e211) return 211;
			else if (number < 1.0e212) return 212;
			else if (number < 1.0e213) return 213;
			else if (number < 1.0e214) return 214;
			else if (number < 1.0e215) return 215;
			else if (number < 1.0e216) return 216;
			else if (number < 1.0e217) return 217;
			else if (number < 1.0e218) return 218;
			else if (number < 1.0e219) return 219;
			else if (number < 1.0e220) return 220;
			else if (number < 1.0e221) return 221;
			else if (number < 1.0e222) return 222;
			else if (number < 1.0e223) return 223;
			else if (number < 1.0e224) return 224;
			else if (number < 1.0e225) return 225;
			else if (number < 1.0e226) return 226;
			else if (number < 1.0e227) return 227;
			else if (number < 1.0e228) return 228;
			else if (number < 1.0e229) return 229;
			else if (number < 1.0e230) return 230;
			else if (number < 1.0e231) return 231;
			else if (number < 1.0e232) return 232;
			else if (number < 1.0e233) return 233;
			else if (number < 1.0e234) return 234;
			else if (number < 1.0e235) return 235;
			else if (number < 1.0e236) return 236;
			else if (number < 1.0e237) return 237;
			else if (number < 1.0e238) return 238;
			else if (number < 1.0e239) return 239;
			else if (number < 1.0e240) return 240;
			else if (number < 1.0e241) return 241;
			else if (number < 1.0e242) return 242;
			else if (number < 1.0e243) return 243;
			else if (number < 1.0e244) return 244;
			else if (number < 1.0e245) return 245;
			else if (number < 1.0e246) return 246;
			else if (number < 1.0e247) return 247;
			else if (number < 1.0e248) return 248;
			else if (number < 1.0e249) return 249;
			else if (number < 1.0e250) return 250;
			else if (number < 1.0e251) return 251;
			else if (number < 1.0e252) return 252;
			else if (number < 1.0e253) return 253;
			else if (number < 1.0e254) return 254;
			else if (number < 1.0e255) return 255;
			else if (number < 1.0e256) return 256;
			else if (number < 1.0e257) return 257;
			else if (number < 1.0e258) return 258;
			else if (number < 1.0e259) return 259;
			else if (number < 1.0e260) return 260;
			else if (number < 1.0e261) return 261;
			else if (number < 1.0e262) return 262;
			else if (number < 1.0e263) return 263;
			else if (number < 1.0e264) return 264;
			else if (number < 1.0e265) return 265;
			else if (number < 1.0e266) return 266;
			else if (number < 1.0e267) return 267;
			else if (number < 1.0e268) return 268;
			else if (number < 1.0e269) return 269;
			else if (number < 1.0e270) return 270;
			else if (number < 1.0e271) return 271;
			else if (number < 1.0e272) return 272;
			else if (number < 1.0e273) return 273;
			else if (number < 1.0e274) return 274;
			else if (number < 1.0e275) return 275;
			else if (number < 1.0e276) return 276;
			else if (number < 1.0e277) return 277;
			else if (number < 1.0e278) return 278;
			else if (number < 1.0e279) return 279;
			else if (number < 1.0e280) return 280;
			else if (number < 1.0e281) return 281;
			else if (number < 1.0e282) return 282;
			else if (number < 1.0e283) return 283;
			else if (number < 1.0e284) return 284;
			else if (number < 1.0e285) return 285;
			else if (number < 1.0e286) return 286;
			else if (number < 1.0e287) return 287;
			else if (number < 1.0e288) return 288;
			else if (number < 1.0e289) return 289;
			else if (number < 1.0e290) return 290;
			else if (number < 1.0e291) return 291;
			else if (number < 1.0e292) return 292;
			else if (number < 1.0e293) return 293;
			else if (number < 1.0e294) return 294;
			else if (number < 1.0e295) return 295;
			else if (number < 1.0e296) return 296;
			else if (number < 1.0e297) return 297;
			else if (number < 1.0e298) return 298;
			else if (number < 1.0e299) return 299;
			else if (number < 1.0e300) return 300;
			else if (number < 1.0e301) return 301;
			else if (number < 1.0e302) return 302;
			else if (number < 1.0e303) return 303;
			else if (number < 1.0e304) return 304;
			else if (number < 1.0e305) return 305;
			else if (number < 1.0e306) return 306;
			else if (number < 1.0e307) return 307;
			else if (number < 1.0e308) return 308;
			else return 309;
		}
		/**
		 * Number of digits needed to represent given number in numeral system with given base.
		 * @param number              The number
		 * @param numeralSystemBase   Numeral system base above 0
		 * @return                    Returns number of digits. In case when numeralSystemBase is lower than
		 *                            1 then -1 is returned.
		 */
		public static long numberOfDigits(long number, long numeralSystemBase) {
			if (numeralSystemBase < 1) return -1;
			if (number < 0) number = -number;
			if (numeralSystemBase == 10) return numberOfDigits(number);
			if (numeralSystemBase == 1) return (int)number;
			if (number < numeralSystemBase) return 1;
			long quotient = number;
			long digitsNum = 0;
			while (quotient >= 1) {
				quotient = quotient / numeralSystemBase;
				digitsNum++;
			}
			return digitsNum;
		}
		/**
		 * Number of digits needed to represent given number (its integer part) in numeral system with given base.
		 * @param number              The number
		 * @param numeralSystemBase   Numeral system base above 0
		 * @return                    Returns number of digits. In case when numeralSystemBase is lower than
		 *                            1 then Double.NaN is returned. If number or numeralSystemBase is Double.NaN
		 *                            then Double.NaN is returned. If numeralSystemBase is infinite then Double.NaN
		 *                            is returned.
		 */
		public static double numberOfDigits(double number, double numeralSystemBase) {
			if (Double.IsNaN(number)) return Double.NaN;
			if (Double.IsNaN(numeralSystemBase)) return Double.NaN;
			if (Double.IsInfinity(numeralSystemBase)) return Double.NaN;
			if (numeralSystemBase < 1.0) return Double.NaN;
			if (Double.IsInfinity(number)) return Double.PositiveInfinity;
			if (number < 0.0) number = -number;
			number = MathFunctions.floor(number);
			numeralSystemBase = MathFunctions.floor(numeralSystemBase);
			if (numeralSystemBase == 10.0) return numberOfDigits(number);
			if (numeralSystemBase == 1.0) return (int)number;
			if (number < numeralSystemBase) return 1;
			double quotient = number;
			double digitsNum = 0;
			while (quotient >= 1.0) {
				quotient = MathFunctions.floor(quotient / numeralSystemBase);
				digitsNum++;
			}
			return digitsNum;
		}
	}
}