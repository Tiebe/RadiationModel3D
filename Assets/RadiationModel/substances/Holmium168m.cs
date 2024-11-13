
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium168m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium168m";
        public override double halfLife { get; } = 132.0d;
        public override double atomicWeight { get; } = 167.93559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Holmium168() } },

        };
    }
}
    
    