using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lua.Common
{
    public class EvaluationMachine<TIn, TOut> : IEnumerable<TOut>
    {
        protected readonly IEnumerable<Func<Evaluator<TIn, TOut>>> Evaluators;
        protected IEnumerable<Evaluator<TIn, TOut>> DefaultEvaluators() => Evaluators.Select(e => e());
        protected readonly IEnumerable<TIn> Source;

        public EvaluationMachine(IEnumerable<Func<Evaluator<TIn, TOut>>> evaluators, IEnumerable<TIn> source)
        {
            Evaluators = evaluators;
            Source = source;
        }

        protected IEnumerable<TOut> Evaluate()
        {
            var evaluators = DefaultEvaluators();
            foreach (var character in Source)
            {
                var next = StepEvaluators(evaluators, character);
                if (evaluators.HasSingle() && !next.Any())
                {
                    yield return evaluators.Single().Value;
                    evaluators = StepEvaluators(DefaultEvaluators(), character);
                }
                else if (!next.Any())
                {
                    yield return evaluators.Single(e => e.State == EvaluatorState.Accepted).Value;
                    evaluators = StepEvaluators(DefaultEvaluators(), character);
                }
                else
                {
                    evaluators = next;
                }
            }
        }

        protected Evaluator<TIn, TOut>[] StepEvaluators(IEnumerable<Evaluator<TIn, TOut>> evaluators, TIn character)
        {
            return evaluators.Select(e =>
            {
                var n = e.Copy();
                n.State = n.Evaluate(character);
                return n;
            }).Where(e => e.State != EvaluatorState.Failed)
              .ToArray();
        }

        public IEnumerator<TOut> GetEnumerator() => Evaluate().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
