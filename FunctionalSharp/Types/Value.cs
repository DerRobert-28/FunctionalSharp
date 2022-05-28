namespace DerRobert.FunctionalSharp.Types {

	using DerRobert.FunctionalSharp.Exceptions;
	using DerRobert.FunctionalSharp.Types.Consumers;
	using DerRobert.FunctionalSharp.Types.Functions;


	public delegate T? Value<T>();

	public static class Value {

		public static Value<T> of<T>(T value) => Equals(value, null)? none<T>(): some(value);
		public static Value<T> none<T>() => () => default;
		public static Value<T> some<T>(T value) => () => value;

		public static void map<T>(this Value<T> value, Consumer1<T?> mapper) {
			if(mapper == null) {
				throw new MappingException("Mapper cannot be NULL");
			} else if(value != null) {
				mapper.Invoke(value.Invoke());
			}
		}

		public static Value<R> map<T, R>(this Value<T> value, Function1<T?, R> mapper) {
			if(mapper == null) {
				throw new MappingException("Mapper cannot be NULL");
			} else if(value == null) {
				return none<R>();
			} else {
				return of(mapper.Invoke(value.Invoke()));
			}
		}

		public static T? get<T>(this Value<T> value) {
			if(value == null) {
				throw new EvaluationException("No value present");
			} else {
				T? t = value.Invoke();
				if(t == null) {
					throw new EvaluationException("No value present");
				}
				return t;
			}
		}

	}

}
