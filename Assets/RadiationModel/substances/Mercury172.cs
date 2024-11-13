
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury172 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury172";
        public override double halfLife { get; } = 0.00023d;
        public override double atomicWeight { get; } = 171.99886d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Platinum168() } },

        };
    }
}
    
    