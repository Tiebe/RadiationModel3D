using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium192 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium192";
        public override double halfLife { get; } = 0.0322d;
        public override double atomicWeight { get; } = 191.99134d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead188() }, { 1.0d, new AlphaParticle(8342002.09) } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead192() }, { 1.0d, new BetaParticle(1, 7243000.0) } } },

        };
    }
}
    