using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt77 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt77";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 76.97648d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel77() }, { 1.0d, new BetaParticle(-1, 7720000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    