using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon33 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon33";
        public override double halfLife { get; } = 6.11d;
        public override double atomicWeight { get; } = 32.97798d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus33() }, { 1.0d, new BetaParticle(-1, 2911550.0) } } },

        };
    }
}
    