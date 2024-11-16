using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum157m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum157m";
        public override double halfLife { get; } = 0.0043d;
        public override double atomicWeight { get; } = 156.96826d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7407002.09), new Lutetium153() } },
            { 0.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Hafnium156() } },

        };
    }
}
    
    