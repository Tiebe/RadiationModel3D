using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron62 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron62";
        public override double halfLife { get; } = 68.0d;
        public override double atomicWeight { get; } = 61.93679d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt62() }, { 1.0d, new BetaParticle(-1, 1272950.0) }, { 1.0d, new GammaParticle(506100.0, 0.00245) } } },

        };
    }
}
    