namespace DerRobert.FunctionalSharp.Exceptions {

	public class NoSuchElementException: FunctionalException<NoSuchElementException> {

		private NoSuchElementException(string reason): base(reason) {}

	}

}
