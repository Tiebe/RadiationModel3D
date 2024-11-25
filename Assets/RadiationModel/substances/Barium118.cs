using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium118";
        public override double halfLife { get; } = 5.5d;
        public override double atomicWeight { get; } = 117.93323d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon118() }, { 1.0d, new BetaParticle(1, 7939500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    