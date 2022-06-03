namespace DerRobert.FunctionalSharp.Exceptions {

	public class NullPointerException: FunctionalException<NullPointerException> {

		private NullPointerException(string reason): base(reason) {}

	}

}
