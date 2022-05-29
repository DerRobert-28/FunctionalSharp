namespace DerRobert.FunctionalSharp.Exceptions {

	public class EvaluationException: FunctionalException<EvaluationException> {

		private EvaluationException(string reason): base(reason) {}

	}

}
