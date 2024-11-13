
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon218 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon218";
        public override double halfLife { get; } = 0.03375d;
        public override double atomicWeight { get; } = 218.0056d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Polonium214() } },

        };
    }
}
    
    