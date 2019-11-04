namespace System {
	public static class ActionCurryExtensions {
		public static Action Curry<T1>(this Action<T1> action, T1 arg1) {
			return new Action(() => action(arg1));
		}

		public static Action<T2> Curry<T1, T2>(this Action<T1, T2> action, T1 arg1) {
			return new Action<T2>((arg2) => action(arg1, arg2));
		}

		public static Action Curry<T1, T2>(this Action<T1, T2> action, T1 arg1, T2 arg2) {
			return new Action(() => action(arg1, arg2));
		}

		public static Action<T2, T3> Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1) {
			return new Action<T2, T3>((arg2, arg3) => action(arg1, arg2, arg3));
		}

		public static Action<T3> Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2) {
			return new Action<T3>((arg3) => action(arg1, arg2, arg3));
		}

		public static Action Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action(() => action(arg1, arg2, arg3));
		}

		public static Action<T2, T3, T4> Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1) {
			return new Action<T2, T3, T4>((arg2, arg3, arg4) => action(arg1, arg2, arg3, arg4));
		}

		public static Action<T3, T4> Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4>((arg3, arg4) => action(arg1, arg2, arg3, arg4));
		}

		public static Action<T4> Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4>((arg4) => action(arg1, arg2, arg3, arg4));
		}

		public static Action Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action(() => action(arg1, arg2, arg3, arg4));
		}

		public static Action<T2, T3, T4, T5> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1) {
			return new Action<T2, T3, T4, T5>((arg2, arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5));
		}

		public static Action<T3, T4, T5> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5>((arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5));
		}

		public static Action<T4, T5> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5>((arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5));
		}

		public static Action<T5> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5>((arg5) => action(arg1, arg2, arg3, arg4, arg5));
		}

		public static Action Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5));
		}

		public static Action<T2, T3, T4, T5, T6> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6>((arg2, arg3, arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Action<T3, T4, T5, T6> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6>((arg3, arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Action<T4, T5, T6> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6>((arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Action<T5, T6> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6>((arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Action<T6> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6>((arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6));
		}

		public static Action<T2, T3, T4, T5, T6, T7> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6, T7>((arg2, arg3, arg4, arg5, arg6, arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Action<T3, T4, T5, T6, T7> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6, T7>((arg3, arg4, arg5, arg6, arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Action<T4, T5, T6, T7> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6, T7>((arg4, arg5, arg6, arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Action<T5, T6, T7> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6, T7>((arg5, arg6, arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Action<T6, T7> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6, T7>((arg6, arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Action<T7> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action<T7>((arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}

		public static Action<T2, T3, T4, T5, T6, T7, T8> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6, T7, T8>((arg2, arg3, arg4, arg5, arg6, arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Action<T3, T4, T5, T6, T7, T8> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6, T7, T8>((arg3, arg4, arg5, arg6, arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Action<T4, T5, T6, T7, T8> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6, T7, T8>((arg4, arg5, arg6, arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Action<T5, T6, T7, T8> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6, T7, T8>((arg5, arg6, arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Action<T6, T7, T8> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6, T7, T8>((arg6, arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Action<T7, T8> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action<T7, T8>((arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Action<T8> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Action<T8>((arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}

		public static Action<T2, T3, T4, T5, T6, T7, T8, T9> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6, T7, T8, T9>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Action<T3, T4, T5, T6, T7, T8, T9> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6, T7, T8, T9>((arg3, arg4, arg5, arg6, arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Action<T4, T5, T6, T7, T8, T9> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6, T7, T8, T9>((arg4, arg5, arg6, arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Action<T5, T6, T7, T8, T9> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6, T7, T8, T9>((arg5, arg6, arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Action<T6, T7, T8, T9> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6, T7, T8, T9>((arg6, arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Action<T7, T8, T9> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action<T7, T8, T9>((arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Action<T8, T9> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Action<T8, T9>((arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Action<T9> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Action<T9>((arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}

		public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6, T7, T8, T9, T10>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Action<T3, T4, T5, T6, T7, T8, T9, T10> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6, T7, T8, T9, T10>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Action<T4, T5, T6, T7, T8, T9, T10> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6, T7, T8, T9, T10>((arg4, arg5, arg6, arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Action<T5, T6, T7, T8, T9, T10> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6, T7, T8, T9, T10>((arg5, arg6, arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Action<T6, T7, T8, T9, T10> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6, T7, T8, T9, T10>((arg6, arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Action<T7, T8, T9, T10> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action<T7, T8, T9, T10>((arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Action<T8, T9, T10> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Action<T8, T9, T10>((arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Action<T9, T10> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Action<T9, T10>((arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Action<T10> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Action<T10>((arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}

		public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6, T7, T8, T9, T10, T11>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action<T4, T5, T6, T7, T8, T9, T10, T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6, T7, T8, T9, T10, T11>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action<T5, T6, T7, T8, T9, T10, T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6, T7, T8, T9, T10, T11>((arg5, arg6, arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action<T6, T7, T8, T9, T10, T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6, T7, T8, T9, T10, T11>((arg6, arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action<T7, T8, T9, T10, T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action<T7, T8, T9, T10, T11>((arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action<T8, T9, T10, T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Action<T8, T9, T10, T11>((arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action<T9, T10, T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Action<T9, T10, T11>((arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action<T10, T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Action<T10, T11>((arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action<T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Action<T11>((arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}

		public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6, T7, T8, T9, T10, T11, T12>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T5, T6, T7, T8, T9, T10, T11, T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6, T7, T8, T9, T10, T11, T12>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T6, T7, T8, T9, T10, T11, T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6, T7, T8, T9, T10, T11, T12>((arg6, arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T7, T8, T9, T10, T11, T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action<T7, T8, T9, T10, T11, T12>((arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T8, T9, T10, T11, T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Action<T8, T9, T10, T11, T12>((arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T9, T10, T11, T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Action<T9, T10, T11, T12>((arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T10, T11, T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Action<T10, T11, T12>((arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T11, T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Action<T11, T12>((arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T12> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Action<T12>((arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}

		public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6, T7, T8, T9, T10, T11, T12, T13>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T6, T7, T8, T9, T10, T11, T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6, T7, T8, T9, T10, T11, T12, T13>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T7, T8, T9, T10, T11, T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action<T7, T8, T9, T10, T11, T12, T13>((arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T8, T9, T10, T11, T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Action<T8, T9, T10, T11, T12, T13>((arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T9, T10, T11, T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Action<T9, T10, T11, T12, T13>((arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T10, T11, T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Action<T10, T11, T12, T13>((arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T11, T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Action<T11, T12, T13>((arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T12, T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Action<T12, T13>((arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T13> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
			return new Action<T13>((arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}

		public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6, T7, T8, T9, T10, T11, T12, T13, T14>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T7, T8, T9, T10, T11, T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action<T7, T8, T9, T10, T11, T12, T13, T14>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T8, T9, T10, T11, T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Action<T8, T9, T10, T11, T12, T13, T14>((arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T9, T10, T11, T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Action<T9, T10, T11, T12, T13, T14>((arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T10, T11, T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Action<T10, T11, T12, T13, T14>((arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T11, T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Action<T11, T12, T13, T14>((arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T12, T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Action<T12, T13, T14>((arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T13, T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
			return new Action<T13, T14>((arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T14> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {
			return new Action<T14>((arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}

		public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T7, T8, T9, T10, T11, T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action<T7, T8, T9, T10, T11, T12, T13, T14, T15>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T8, T9, T10, T11, T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Action<T8, T9, T10, T11, T12, T13, T14, T15>((arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T9, T10, T11, T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Action<T9, T10, T11, T12, T13, T14, T15>((arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T10, T11, T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Action<T10, T11, T12, T13, T14, T15>((arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T11, T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Action<T11, T12, T13, T14, T15>((arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T12, T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Action<T12, T13, T14, T15>((arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T13, T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
			return new Action<T13, T14, T15>((arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T14, T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {
			return new Action<T14, T15>((arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T15> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {
			return new Action<T15>((arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}

		public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1) {
			return new Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2) {
			return new Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3) {
			return new Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
			return new Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
			return new Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
			return new Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T8, T9, T10, T11, T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
			return new Action<T8, T9, T10, T11, T12, T13, T14, T15, T16>((arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T9, T10, T11, T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
			return new Action<T9, T10, T11, T12, T13, T14, T15, T16>((arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T10, T11, T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
			return new Action<T10, T11, T12, T13, T14, T15, T16>((arg10, arg11, arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T11, T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
			return new Action<T11, T12, T13, T14, T15, T16>((arg11, arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T12, T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
			return new Action<T12, T13, T14, T15, T16>((arg12, arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T13, T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
			return new Action<T13, T14, T15, T16>((arg13, arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T14, T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {
			return new Action<T14, T15, T16>((arg14, arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T15, T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {
			return new Action<T15, T16>((arg15, arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action<T16> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) {
			return new Action<T16>((arg16) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}

		public static Action Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) {
			return new Action(() => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}
	}
}