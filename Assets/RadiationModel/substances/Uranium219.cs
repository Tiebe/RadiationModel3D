using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium219";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 219.02501d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10972002.09), new Thorium215() } },

        };
    }
}
    
    