
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine95m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine95m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 94.9535d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Bromine95() } },

        };
    }
}
    
    