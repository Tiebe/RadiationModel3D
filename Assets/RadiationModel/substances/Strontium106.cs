using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium106";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 105.96318d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium106() }, { 1.0d, new BetaParticle(-1, 5745000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    