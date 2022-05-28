namespace DerRobert.FunctionalSharp.Exceptions {

	public abstract class FunctionalException: Exception {
	
		protected FunctionalException(string reason): base(reason) {}

	}

}
