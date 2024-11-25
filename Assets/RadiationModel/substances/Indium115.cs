using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium115";
        public override double halfLife { get; } = 1.3916604354795072e+22d;
        public override double atomicWeight { get; } = 114.90388d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin115() }, { 1.0d, new BetaParticle(-1, 248744.5) } } },

        };
    }
}
    