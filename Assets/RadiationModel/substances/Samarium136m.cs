
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium136m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium136m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 135.93071d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Samarium136() } },

        };
    }
}
    
    