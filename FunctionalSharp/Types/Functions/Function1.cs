namespace DerRobert.FunctionalSharp.Types.Functions {

	public delegate R Function1<T, R>(T a);

	public static class Function1_ {

		public static R apply<T, R>(this Function1<T, R> f, T a) => f.Invoke(a);
		public static Function1<T, R> apply<T, R>(this Function1<T, R> f) => f;

		public static int arity<T, R>(this Function1<T, R> f) => 1;

		public static T identity<T>(this Function1<T, T> f, T t) => t;

	}

}
