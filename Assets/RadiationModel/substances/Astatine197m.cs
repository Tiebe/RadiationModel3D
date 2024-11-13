
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine197m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine197m";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 196.99322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth193() } },

            { 4e-05d, new List<RadioactiveSubstance> { new GammaParticle(), new Astatine197() } },

        };
    }
}
    
    