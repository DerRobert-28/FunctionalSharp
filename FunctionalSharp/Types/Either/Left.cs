namespace DerRobert.FunctionalSharp.Types {

	using DerRobert.FunctionalSharp.Exceptions;
	using DerRobert.FunctionalSharp.Types.Tuples;
	
	
	public class Left {

		public static Either<L, R> of<L, R>(Tuple2<L, R> tuple2) {
			if(tuple2 == null) {
				throw new EvaluationException("No value present");
			} else {
				L? value = tuple2._1;
				if(value == null) {
					throw new EvaluationException("No value present");
				}
				return Left<L, R>.of(value);
			}
		}

	}


	public class Left<L, R>: Either<L, R> {
			
		public override R? get() => throw new EvaluationException("No value present: get()");
		public override L? getLeft() => (L?)value[0];
		public override bool isLeft() => true;
		public override bool isRight() => false;
		public static Either<L, R> of(L l) => new Left<L, R>(l);
		
		private Left(L l): base(new object?[] {l, null}) { }

	}

}
