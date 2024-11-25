using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium231";
        public override double halfLife { get; } = 2928.0d;
        public override double atomicWeight { get; } = 231.03824d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium231() }, { 1.0d, new BetaParticle(1, 1097849.99999) }, { 0.002d, new GammaParticle(511000.0, 0.00243) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium227() }, { 1.0d, new AlphaParticle(7387002.09) } } },

        };
    }
}
    