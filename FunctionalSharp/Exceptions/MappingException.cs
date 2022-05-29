namespace DerRobert.FunctionalSharp.Exceptions {

	public class MappingException: FunctionalException<MappingException> {

		private MappingException(string reason): base(reason) {}

	}

}
