using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium143m";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 142.94433d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium143() }, { 1.0d, new BetaParticle(1, 8186000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    