using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon196 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon196";
        public override double halfLife { get; } = 0.0044d;
        public override double atomicWeight { get; } = 196.00212d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium192() }, { 1.0d, new AlphaParticle(8638002.09) } } },
            { 0.0006d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium196() }, { 1.0d, new BetaParticle(1, 7722000.0) } } },

        };
    }
}
    