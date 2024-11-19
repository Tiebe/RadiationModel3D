using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium203m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium203m";
        public override double halfLife { get; } = 0.025d;
        public override double atomicWeight { get; } = 203.0095d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9005002.09), new Radon199() } },

        };
    }
}
    
    