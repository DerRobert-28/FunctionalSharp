namespace DerRobert.FunctionalSharp.Exceptions {

	public class NullPointerException: FunctionalException<NoSuchElementException> {

		private NullPointerException(string reason): base(reason) {}

	}

}
