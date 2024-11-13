
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium209m : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium209m";
        public override double halfLife { get; } = 0.0031d;
        public override double atomicWeight { get; } = 209.018d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radium205() } },

        };
    }
}
    
    