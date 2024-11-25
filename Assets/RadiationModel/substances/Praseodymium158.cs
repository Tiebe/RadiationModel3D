using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium158";
        public override double halfLife { get; } = 0.181d;
        public override double atomicWeight { get; } = 157.9526d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium158() }, { 1.0d, new BetaParticle(-1, 4842550.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    