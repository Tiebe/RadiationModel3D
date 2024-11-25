using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon202 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon202";
        public override double halfLife { get; } = 9.7d;
        public override double atomicWeight { get; } = 201.99326d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium198() }, { 1.0d, new AlphaParticle(7795002.09) } } },
            { 0.22d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium202() }, { 1.0d, new BetaParticle(1, 5833500.0) } } },

        };
    }
}
    