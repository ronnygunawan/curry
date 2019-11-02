namespace System {
	public static class Curry {
		public static Curry<T1, TResult> From<T1, TResult>(Func<T1, TResult> func) => func;
		public static Curry<T1, T2, TResult> From<T1, T2, TResult>(Func<T1, T2, TResult> func) => func;
		public static Curry<T1, T2, T3, TResult> From<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, TResult> From<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, TResult> From<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, TResult> From<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, T7, TResult> From<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult> From<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func) => func;
		public static Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func) => func;
	}

	public class Curry<T1, TResult> {
		private Func<T1, TResult> Func { get; }

		public Curry(Func<T1, TResult> func) {
			Func = func;
		}

		public TResult this[T1 arg1] => Func(arg1);
		public static implicit operator Curry<T1, TResult>(Func<T1, TResult> func) => new Curry<T1, TResult>(func);
		public static implicit operator Func<T1, TResult>(Curry<T1, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, TResult> {
		private Func<T1, T2, TResult> Func { get; }

		public Curry(Func<T1, T2, TResult> func) {
			Func = func;
		}

		public Curry<T2, TResult> this[T1 arg1] => new Curry<T2, TResult>((arg2) => Func(arg1, arg2));
		public TResult this[T1 arg1, T2 arg2] => Func(arg1, arg2);
		public static implicit operator Curry<T1, T2, TResult>(Func<T1, T2, TResult> func) => new Curry<T1, T2, TResult>(func);
		public static implicit operator Func<T1, T2, TResult>(Curry<T1, T2, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, TResult> {
		private Func<T1, T2, T3, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, TResult> this[T1 arg1] => new Curry<T2, T3, TResult>((arg2, arg3) => Func(arg1, arg2, arg3));
		public Curry<T3, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, TResult>((arg3) => Func(arg1, arg2, arg3));
		public TResult this[T1 arg1, T2 arg2, T3 arg3] => Func(arg1, arg2, arg3);
		public static implicit operator Curry<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> func) => new Curry<T1, T2, T3, TResult>(func);
		public static implicit operator Func<T1, T2, T3, TResult>(Curry<T1, T2, T3, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, TResult> {
		private Func<T1, T2, T3, T4, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, TResult> this[T1 arg1] => new Curry<T2, T3, T4, TResult>((arg2, arg3, arg4) => Func(arg1, arg2, arg3, arg4));
		public Curry<T3, T4, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, TResult>((arg3, arg4) => Func(arg1, arg2, arg3, arg4));
		public Curry<T4, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, TResult>((arg4) => Func(arg1, arg2, arg3, arg4));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => Func(arg1, arg2, arg3, arg4);
		public static implicit operator Curry<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> func) => new Curry<T1, T2, T3, T4, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, TResult>(Curry<T1, T2, T3, T4, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, TResult> {
		private Func<T1, T2, T3, T4, T5, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, TResult>((arg2, arg3, arg4, arg5) => Func(arg1, arg2, arg3, arg4, arg5));
		public Curry<T3, T4, T5, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, TResult>((arg3, arg4, arg5) => Func(arg1, arg2, arg3, arg4, arg5));
		public Curry<T4, T5, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, TResult>((arg4, arg5) => Func(arg1, arg2, arg3, arg4, arg5));
		public Curry<T5, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, TResult>((arg5) => Func(arg1, arg2, arg3, arg4, arg5));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => Func(arg1, arg2, arg3, arg4, arg5);
		public static implicit operator Curry<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> func) => new Curry<T1, T2, T3, T4, T5, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, TResult>(Curry<T1, T2, T3, T4, T5, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, TResult>((arg2, arg3, arg4, arg5, arg6) => Func(arg1, arg2, arg3, arg4, arg5, arg6));
		public Curry<T3, T4, T5, T6, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, TResult>((arg3, arg4, arg5, arg6) => Func(arg1, arg2, arg3, arg4, arg5, arg6));
		public Curry<T4, T5, T6, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, TResult>((arg4, arg5, arg6) => Func(arg1, arg2, arg3, arg4, arg5, arg6));
		public Curry<T5, T6, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, TResult>((arg5, arg6) => Func(arg1, arg2, arg3, arg4, arg5, arg6));
		public Curry<T6, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, TResult>((arg6) => Func(arg1, arg2, arg3, arg4, arg5, arg6));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => Func(arg1, arg2, arg3, arg4, arg5, arg6);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, TResult>(Curry<T1, T2, T3, T4, T5, T6, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, T7, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, T7, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, T7, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, T7, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, T7, TResult>((arg2, arg3, arg4, arg5, arg6, arg7) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		public Curry<T3, T4, T5, T6, T7, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, T7, TResult>((arg3, arg4, arg5, arg6, arg7) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		public Curry<T4, T5, T6, T7, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, T7, TResult>((arg4, arg5, arg6, arg7) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		public Curry<T5, T6, T7, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, T7, TResult>((arg5, arg6, arg7) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		public Curry<T6, T7, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, T7, TResult>((arg6, arg7) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		public Curry<T7, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => new Curry<T7, TResult>((arg7) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7] => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, TResult>(Curry<T1, T2, T3, T4, T5, T6, T7, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, T7, T8, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, T7, T8, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		public Curry<T3, T4, T5, T6, T7, T8, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, T7, T8, TResult>((arg3, arg4, arg5, arg6, arg7, arg8) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		public Curry<T4, T5, T6, T7, T8, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, T7, T8, TResult>((arg4, arg5, arg6, arg7, arg8) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		public Curry<T5, T6, T7, T8, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, T7, T8, TResult>((arg5, arg6, arg7, arg8) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		public Curry<T6, T7, T8, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, T7, T8, TResult>((arg6, arg7, arg8) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		public Curry<T7, T8, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => new Curry<T7, T8, TResult>((arg7, arg8) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		public Curry<T8, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7] => new Curry<T8, TResult>((arg8) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8] => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, T7, T8, T9, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, T7, T8, T9, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		public Curry<T3, T4, T5, T6, T7, T8, T9, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, T7, T8, T9, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		public Curry<T4, T5, T6, T7, T8, T9, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, T7, T8, T9, TResult>((arg4, arg5, arg6, arg7, arg8, arg9) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		public Curry<T5, T6, T7, T8, T9, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, T7, T8, T9, TResult>((arg5, arg6, arg7, arg8, arg9) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		public Curry<T6, T7, T8, T9, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, T7, T8, T9, TResult>((arg6, arg7, arg8, arg9) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		public Curry<T7, T8, T9, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => new Curry<T7, T8, T9, TResult>((arg7, arg8, arg9) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		public Curry<T8, T9, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7] => new Curry<T8, T9, TResult>((arg8, arg9) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		public Curry<T9, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8] => new Curry<T9, TResult>((arg9) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9] => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		public Curry<T3, T4, T5, T6, T7, T8, T9, T10, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, T7, T8, T9, T10, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		public Curry<T4, T5, T6, T7, T8, T9, T10, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, T7, T8, T9, T10, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		public Curry<T5, T6, T7, T8, T9, T10, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, T7, T8, T9, T10, TResult>((arg5, arg6, arg7, arg8, arg9, arg10) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		public Curry<T6, T7, T8, T9, T10, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, T7, T8, T9, T10, TResult>((arg6, arg7, arg8, arg9, arg10) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		public Curry<T7, T8, T9, T10, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => new Curry<T7, T8, T9, T10, TResult>((arg7, arg8, arg9, arg10) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		public Curry<T8, T9, T10, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7] => new Curry<T8, T9, T10, TResult>((arg8, arg9, arg10) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		public Curry<T9, T10, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8] => new Curry<T9, T10, TResult>((arg9, arg10) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		public Curry<T10, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9] => new Curry<T10, TResult>((arg10) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10] => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		public Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		public Curry<T4, T5, T6, T7, T8, T9, T10, T11, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, T7, T8, T9, T10, T11, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		public Curry<T5, T6, T7, T8, T9, T10, T11, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, T7, T8, T9, T10, T11, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		public Curry<T6, T7, T8, T9, T10, T11, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, T7, T8, T9, T10, T11, TResult>((arg6, arg7, arg8, arg9, arg10, arg11) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		public Curry<T7, T8, T9, T10, T11, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => new Curry<T7, T8, T9, T10, T11, TResult>((arg7, arg8, arg9, arg10, arg11) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		public Curry<T8, T9, T10, T11, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7] => new Curry<T8, T9, T10, T11, TResult>((arg8, arg9, arg10, arg11) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		public Curry<T9, T10, T11, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8] => new Curry<T9, T10, T11, TResult>((arg9, arg10, arg11) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		public Curry<T10, T11, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9] => new Curry<T10, T11, TResult>((arg10, arg11) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		public Curry<T11, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10] => new Curry<T11, TResult>((arg11) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11] => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public Curry<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public Curry<T5, T6, T7, T8, T9, T10, T11, T12, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, T7, T8, T9, T10, T11, T12, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public Curry<T6, T7, T8, T9, T10, T11, T12, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, T7, T8, T9, T10, T11, T12, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public Curry<T7, T8, T9, T10, T11, T12, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => new Curry<T7, T8, T9, T10, T11, T12, TResult>((arg7, arg8, arg9, arg10, arg11, arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public Curry<T8, T9, T10, T11, T12, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7] => new Curry<T8, T9, T10, T11, T12, TResult>((arg8, arg9, arg10, arg11, arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public Curry<T9, T10, T11, T12, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8] => new Curry<T9, T10, T11, T12, TResult>((arg9, arg10, arg11, arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public Curry<T10, T11, T12, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9] => new Curry<T10, T11, T12, TResult>((arg10, arg11, arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public Curry<T11, T12, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10] => new Curry<T11, T12, TResult>((arg11, arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public Curry<T12, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11] => new Curry<T12, TResult>((arg12) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12] => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T6, T7, T8, T9, T10, T11, T12, T13, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, T7, T8, T9, T10, T11, T12, T13, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T7, T8, T9, T10, T11, T12, T13, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => new Curry<T7, T8, T9, T10, T11, T12, T13, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T8, T9, T10, T11, T12, T13, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7] => new Curry<T8, T9, T10, T11, T12, T13, TResult>((arg8, arg9, arg10, arg11, arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T9, T10, T11, T12, T13, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8] => new Curry<T9, T10, T11, T12, T13, TResult>((arg9, arg10, arg11, arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T10, T11, T12, T13, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9] => new Curry<T10, T11, T12, T13, TResult>((arg10, arg11, arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T11, T12, T13, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10] => new Curry<T11, T12, T13, TResult>((arg11, arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T12, T13, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11] => new Curry<T12, T13, TResult>((arg12, arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public Curry<T13, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12] => new Curry<T13, TResult>((arg13) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13] => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T7, T8, T9, T10, T11, T12, T13, T14, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => new Curry<T7, T8, T9, T10, T11, T12, T13, T14, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T8, T9, T10, T11, T12, T13, T14, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7] => new Curry<T8, T9, T10, T11, T12, T13, T14, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T9, T10, T11, T12, T13, T14, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8] => new Curry<T9, T10, T11, T12, T13, T14, TResult>((arg9, arg10, arg11, arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T10, T11, T12, T13, T14, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9] => new Curry<T10, T11, T12, T13, T14, TResult>((arg10, arg11, arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T11, T12, T13, T14, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10] => new Curry<T11, T12, T13, T14, TResult>((arg11, arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T12, T13, T14, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11] => new Curry<T12, T13, T14, TResult>((arg12, arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T13, T14, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12] => new Curry<T13, T14, TResult>((arg13, arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public Curry<T14, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13] => new Curry<T14, TResult>((arg14) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14] => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => new Curry<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T8, T9, T10, T11, T12, T13, T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7] => new Curry<T8, T9, T10, T11, T12, T13, T14, T15, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T9, T10, T11, T12, T13, T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8] => new Curry<T9, T10, T11, T12, T13, T14, T15, TResult>((arg9, arg10, arg11, arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T10, T11, T12, T13, T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9] => new Curry<T10, T11, T12, T13, T14, T15, TResult>((arg10, arg11, arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T11, T12, T13, T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10] => new Curry<T11, T12, T13, T14, T15, TResult>((arg11, arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T12, T13, T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11] => new Curry<T12, T13, T14, T15, TResult>((arg12, arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T13, T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12] => new Curry<T13, T14, T15, TResult>((arg13, arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T14, T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13] => new Curry<T14, T15, TResult>((arg14, arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public Curry<T15, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14] => new Curry<T15, TResult>((arg15) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15] => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> curry) => curry.Func;
	}
	public class Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> {
		private Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Func { get; }

		public Curry(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func) {
			Func = func;
		}

		public Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> this[T1 arg1] => new Curry<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2] => new Curry<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3] => new Curry<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4] => new Curry<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5] => new Curry<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6] => new Curry<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7] => new Curry<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T9, T10, T11, T12, T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8] => new Curry<T9, T10, T11, T12, T13, T14, T15, T16, TResult>((arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T10, T11, T12, T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9] => new Curry<T10, T11, T12, T13, T14, T15, T16, TResult>((arg10, arg11, arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T11, T12, T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10] => new Curry<T11, T12, T13, T14, T15, T16, TResult>((arg11, arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T12, T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11] => new Curry<T12, T13, T14, T15, T16, TResult>((arg12, arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T13, T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12] => new Curry<T13, T14, T15, T16, TResult>((arg13, arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T14, T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13] => new Curry<T14, T15, T16, TResult>((arg14, arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T15, T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14] => new Curry<T15, T16, TResult>((arg15, arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public Curry<T16, TResult> this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15] => new Curry<T16, TResult>((arg16) => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		public TResult this[T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16] => Func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
		public static implicit operator Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func) => new Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(func);
		public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> curry) => curry.Func;
	}
}