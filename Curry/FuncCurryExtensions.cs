namespace System {
	public static class FuncCurryExtensions {
		public static Func<TResult> Curry<T1, TResult>(this Func<T1, TResult> func, T1 arg1) {
			return new Func<TResult>(() => func(arg1));
		}

		public static Func<T2, TResult> Curry<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 arg1) {
			return new Func<T2, TResult>((arg2) => func(arg1, arg2));
		}

		public static Func<TResult> Curry<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 arg1, T2 arg2) {
			return new Func<TResult>(() => func(arg1, arg2));
		}

		public static Func<T2, T3, TResult> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1) {
			return new Func<T2, T3, TResult>((arg2, arg3) => func(arg1, arg2, arg3));
		}

		public static Func<T3, TResult> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, TResult>((arg3) => func(arg1, arg2, arg3));
		}

		public static Func<TResult> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<TResult>(() => func(arg1, arg2, arg3));
		}

		public static Func<T2, T3, T4, TResult> Curry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, TResult>((arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4));
		}

		public static Func<T3, T4, TResult> Curry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, TResult>((arg3, arg4) => func(arg1, arg2, arg3, arg4));
		}

		public static Func<T4, TResult> Curry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, TResult>((arg4) => func(arg1, arg2, arg3, arg4));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4));
		}

		public static Func<T2, T3, T4, T5, TResult> Curry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, TResult>((arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5));
		}

		public static Func<T3, T4, T5, TResult> Curry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, TResult>((arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5));
		}

		public static Func<T4, T5, TResult> Curry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, TResult>((arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5));
		}

		public static Func<T5, TResult> Curry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, TResult>((arg5) => func(arg1, arg2, arg3, arg4, arg5));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5));
		}

		public static Func<T2, T3, T4, T5, T6, TResult> Curry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, TResult>((arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Func<T3, T4, T5, T6, TResult> Curry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, TResult>((arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Func<T4, T5, T6, TResult> Curry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, TResult>((arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Func<T5, T6, TResult> Curry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, TResult>((arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Func<T6, TResult> Curry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, TResult>((arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Func<T2, T3, T4, T5, T6, T7, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, T7, TResult>((arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Func<T3, T4, T5, T6, T7, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, T7, TResult>((arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Func<T4, T5, T6, T7, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, T7, TResult>((arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Func<T5, T6, T7, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, T7, TResult>((arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Func<T6, T7, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, T7, TResult>((arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Func<T7, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<T7, TResult>((arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, T7, T8, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Func<T3, T4, T5, T6, T7, T8, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, T7, T8, TResult>((arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Func<T4, T5, T6, T7, T8, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, T7, T8, TResult>((arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Func<T5, T6, T7, T8, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, T7, T8, TResult>((arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Func<T6, T7, T8, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, T7, T8, TResult>((arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Func<T7, T8, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<T7, T8, TResult>((arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Func<T8, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Func<T8, TResult>((arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Func<T3, T4, T5, T6, T7, T8, T9, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, T7, T8, T9, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Func<T4, T5, T6, T7, T8, T9, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, T7, T8, T9, TResult>((arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Func<T5, T6, T7, T8, T9, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, T7, T8, T9, TResult>((arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Func<T6, T7, T8, T9, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, T7, T8, T9, TResult>((arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Func<T7, T8, T9, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<T7, T8, T9, TResult>((arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Func<T8, T9, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Func<T8, T9, TResult>((arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Func<T9, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Func<T9, TResult>((arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Func<T4, T5, T6, T7, T8, T9, T10, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, T7, T8, T9, T10, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Func<T5, T6, T7, T8, T9, T10, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, T7, T8, T9, T10, TResult>((arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Func<T6, T7, T8, T9, T10, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, T7, T8, T9, T10, TResult>((arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Func<T7, T8, T9, T10, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<T7, T8, T9, T10, TResult>((arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Func<T8, T9, T10, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Func<T8, T9, T10, TResult>((arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Func<T9, T10, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Func<T9, T10, TResult>((arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Func<T10, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Func<T10, TResult>((arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<T5, T6, T7, T8, T9, T10, T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, T7, T8, T9, T10, T11, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<T6, T7, T8, T9, T10, T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, T7, T8, T9, T10, T11, TResult>((arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<T7, T8, T9, T10, T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<T7, T8, T9, T10, T11, TResult>((arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<T8, T9, T10, T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Func<T8, T9, T10, T11, TResult>((arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<T9, T10, T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Func<T9, T10, T11, TResult>((arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<T10, T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Func<T10, T11, TResult>((arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Func<T11, TResult>((arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T6, T7, T8, T9, T10, T11, T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, T7, T8, T9, T10, T11, T12, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T7, T8, T9, T10, T11, T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<T7, T8, T9, T10, T11, T12, TResult>((arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T8, T9, T10, T11, T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Func<T8, T9, T10, T11, T12, TResult>((arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T9, T10, T11, T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Func<T9, T10, T11, T12, TResult>((arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T10, T11, T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Func<T10, T11, T12, TResult>((arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T11, T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Func<T11, T12, TResult>((arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T12, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Func<T12, TResult>((arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T7, T8, T9, T10, T11, T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<T7, T8, T9, T10, T11, T12, T13, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T8, T9, T10, T11, T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Func<T8, T9, T10, T11, T12, T13, TResult>((arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T9, T10, T11, T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Func<T9, T10, T11, T12, T13, TResult>((arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T10, T11, T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Func<T10, T11, T12, T13, TResult>((arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T11, T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Func<T11, T12, T13, TResult>((arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T12, T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Func<T12, T13, TResult>((arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T13, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
			return new Func<T13, TResult>((arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T8, T9, T10, T11, T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Func<T8, T9, T10, T11, T12, T13, T14, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T9, T10, T11, T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Func<T9, T10, T11, T12, T13, T14, TResult>((arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T10, T11, T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Func<T10, T11, T12, T13, T14, TResult>((arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T11, T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Func<T11, T12, T13, T14, TResult>((arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T12, T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Func<T12, T13, T14, TResult>((arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T13, T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
			return new Func<T13, T14, TResult>((arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T14, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {
			return new Func<T14, TResult>((arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T9, T10, T11, T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Func<T9, T10, T11, T12, T13, T14, T15, TResult>((arg9, arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T10, T11, T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Func<T10, T11, T12, T13, T14, T15, TResult>((arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T11, T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Func<T11, T12, T13, T14, T15, TResult>((arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T12, T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Func<T12, T13, T14, T15, TResult>((arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T13, T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
			return new Func<T13, T14, T15, TResult>((arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T14, T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {
			return new Func<T14, T15, TResult>((arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T15, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {
			return new Func<T15, TResult>((arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1) {
			return new Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2) {
			return new Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3) {
			return new Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T10, T11, T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Func<T10, T11, T12, T13, T14, T15, T16, TResult>((arg10, arg11, arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T11, T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Func<T11, T12, T13, T14, T15, T16, TResult>((arg11, arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T12, T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Func<T12, T13, T14, T15, T16, TResult>((arg12, arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T13, T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
			return new Func<T13, T14, T15, T16, TResult>((arg13, arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T14, T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {
			return new Func<T14, T15, T16, TResult>((arg14, arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T15, T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {
			return new Func<T15, T16, TResult>((arg15, arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<T16, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) {
			return new Func<T16, TResult>((arg16) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Func<TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) {
			return new Func<TResult>(() => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}
	}
}