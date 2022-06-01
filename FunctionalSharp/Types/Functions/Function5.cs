namespace DerRobert.FunctionalSharp.Types.Functions {

	public delegate R Function5<T1, T2, T3, T4, T5, R>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5);

	public static class Function5_ {

		public static R apply<T1, T2, T3, T4, T5, R>(this Function5<T1, T2, T3, T4, T5, R> f, T1 a1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => f.Invoke(a1, arg2, arg3, arg4, arg5);
		public static Function1<T5, R> apply<T1, T2, T3, T4, T5, R>(this Function5<T1, T2, T3, T4, T5, R> f, T1 a1, T2 a2, T3 a3, T4 a4) => a5 => f.apply(a1, a2, a3, a4, a5);
		public static Function2<T4, T5, R> apply<T1, T2, T3, T4, T5, R>(this Function5<T1, T2, T3, T4, T5, R> f, T1 a1, T2 a2, T3 a3) => (a4, a5) => f.apply(a1, a2, a3, a4, a5);
		public static Function3<T3, T4, T5, R> apply<T1, T2, T3, T4, T5, R>(this Function5<T1, T2, T3, T4, T5, R> f, T1 a1, T2 a2) => (a3, a4, a5) => f.apply(a1, a2, a3, a4, a5);
		public static Function4<T2, T3, T4, T5, R> apply<T1, T2, T3, T4, T5, R>(this Function5<T1, T2, T3, T4, T5, R> f, T1 a1) => (a2, a3, a4, a5) => f.apply(a1, a2, a3, a4, a5);
		public static Function5<T1, T2, T3, T4, T5, R> apply<T1, T2, T3, T4, T5, R>(this Function5<T1, T2, T3, T4, T5, R> f) => f;

		public static int arity<T1, T2, T3, T4, T5, R>(this Function5<T1, T2, T3, T4, T5, R> f) => 5;

	}

}
