namespace DerRobert.FunctionalSharp.Types {

	public abstract class Either<L, R> {

		protected readonly object?[] value;
		public abstract R? get();
		public abstract L? getLeft();
		public abstract bool isLeft();
		public abstract bool isRight();
		protected Either(object?[] either) => value = either;

	}

}
