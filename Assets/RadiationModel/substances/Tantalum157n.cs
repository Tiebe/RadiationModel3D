using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum157n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum157n";
        public override double halfLife { get; } = 0.0017d;
        public override double atomicWeight { get; } = 156.96994d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8975047.4), new Lutetium153() } },

        };
    }
}
    
    