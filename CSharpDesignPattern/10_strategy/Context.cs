using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern._10_strategy
{
    class Context
    {
        private IStrategy strategy = null;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void StrategyMethod()
        {
            strategy.StrategyMethod();
        }
    }
}
