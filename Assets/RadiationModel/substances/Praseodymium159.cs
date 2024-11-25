using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium159";
        public override double halfLife { get; } = 0.134d;
        public override double atomicWeight { get; } = 158.95623d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium159() }, { 1.0d, new BetaParticle(-1, 4477000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    