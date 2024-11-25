using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony108 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony108";
        public override double halfLife { get; } = 7.4d;
        public override double atomicWeight { get; } = 107.92223d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium108() }, { 1.0d, new BetaParticle(1, 5837500.0) } } },

        };
    }
}
    