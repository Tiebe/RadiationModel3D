using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium177";
        public override double halfLife { get; } = 29.8d;
        public override double atomicWeight { get; } = 176.9613d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9994d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium177() }, { 1.0d, new BetaParticle(1, 5111000.0) } } },
            { 0.0006d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium173() }, { 1.0d, new AlphaParticle(6104002.09) } } },

        };
    }
}
    