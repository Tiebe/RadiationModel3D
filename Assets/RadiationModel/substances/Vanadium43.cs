using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium43";
        public override double halfLife { get; } = 0.0793d;
        public override double atomicWeight { get; } = 42.98076d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium43() }, { 1.0d, new BetaParticle(1, 9134050.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    