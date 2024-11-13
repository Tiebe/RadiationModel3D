
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium189m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium189m";
        public override double halfLife { get; } = 20916.0d;
        public override double atomicWeight { get; } = 188.95818d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Osmium189() } },

        };
    }
}
    
    