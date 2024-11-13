
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium208";
        public override double halfLife { get; } = 0.0024d;
        public override double atomicWeight { get; } = 208.01792d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radium204() } },

        };
    }
}
    
    