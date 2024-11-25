using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium93";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 92.93668d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium93() }, { 1.0d, new BetaParticle(1, 9118350.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    