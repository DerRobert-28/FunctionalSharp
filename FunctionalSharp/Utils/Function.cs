namespace DerRobert.FunctionalSharp.Utils {

	using DerRobert.FunctionalSharp.Types.Functions;


	public class Function {

		public static Function1<T, T> identity<T>() => t => t;

		public static T identity<T>(T t) => t;

	}


	public class Function<T> {
	
		public static Function1<T, T> identity => t => t;

	}

}
