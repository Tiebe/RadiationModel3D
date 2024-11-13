
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium247m : RadioactiveSubstance
    {
        public override string name { get; } = "Curium247m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 247.0706d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Curium247() } },

        };
    }
}
    
    