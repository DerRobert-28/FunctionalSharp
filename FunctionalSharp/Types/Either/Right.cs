namespace DerRobert.FunctionalSharp.Types {

	using DerRobert.FunctionalSharp.Exceptions;
	using DerRobert.FunctionalSharp.Types.Tuples;


	public class Right {

		public static Either<L, R> of<L, R>(Tuple2<L, R> tuple2) {
			if(tuple2 == null) {
				throw new EvaluationException("No value present");
			} else {
				R? value = tuple2._2;
				if(value == null) {
					throw new EvaluationException("No value present");
				}
				return Right<L, R>.of(value);
			}
		}

	}


	public class Right<L, R>: Either<L, R> {
			
		public override R? get() => (R?)value[1];
		public override L? getLeft() => throw new EvaluationException("No value present: getLeft()");
		public override bool isLeft() => false;
		public override bool isRight() => true;
		public static Either<L, R> of(R r) => new Right<L, R>(r);

		private Right(R r): base(new object?[] {null, r}) { }

	}

}
