namespace Lua.Common
{
    public abstract class Evaluator<TIn, TOut>
    {
        public EvaluatorState State { get; set; }
        public TOut Value { get; set; }

        public abstract EvaluatorState Evaluate(TIn info);

        public abstract Evaluator<TIn, TOut> Copy();
    }
}
