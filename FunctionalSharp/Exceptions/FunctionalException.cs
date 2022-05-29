namespace DerRobert.FunctionalSharp.Exceptions {

	public class FunctionalException<T>: Exception where T: FunctionalException<T> {

		public static FunctionalException<T> because(string reason) => new FunctionalException<T>(reason);
		
		public Type getType() => typeof(T);

		protected FunctionalException(string reason): base(reason) {}

	}

}
