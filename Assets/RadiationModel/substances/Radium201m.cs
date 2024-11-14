using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium201m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium201m";
        public override double halfLife { get; } = 0.006d;
        public override double atomicWeight { get; } = 201.0131d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9285047.4), new Radon197() } },

        };
    }
}
    
    