
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine215 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine215";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 214.99865d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth211() } },

        };
    }
}
    
    