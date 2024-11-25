using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium290 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium290";
        public override double halfLife { get; } = 19.0d;
        public override double atomicWeight { get; } = 290.19187d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new BetaParticle(1, 135156010003.43999) } } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copernicium286() }, { 1.0d, new AlphaParticle(10877002.09) } } },

        };
    }
}
    