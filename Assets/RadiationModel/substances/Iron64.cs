using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron64 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron64";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 63.94099d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt64() }, { 1.0d, new BetaParticle(-1, 2411000.0) }, { 0.07d, new GammaParticle(310800.0, 0.00399) }, { 0.02d, new GammaParticle(1250000.0, 0.00099) } } },

        };
    }
}
    