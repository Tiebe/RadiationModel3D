using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium136";
        public override double halfLife { get; } = 0.085d;
        public override double atomicWeight { get; } = 135.95602d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin136() }, { 1.0d, new BetaParticle(-1, 7600000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    