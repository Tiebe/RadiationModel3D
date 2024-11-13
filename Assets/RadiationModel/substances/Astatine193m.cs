
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine193m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine193m";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 192.99994d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth189() } },

        };
    }
}
    
    