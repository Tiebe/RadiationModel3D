using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium205m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium205m";
        public override double halfLife { get; } = 0.18d;
        public override double atomicWeight { get; } = 205.00651d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8771002.09), new Radon201() } },

        };
    }
}
    
    