using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium93m";
        public override double halfLife { get; } = 508698066.24d;
        public override double atomicWeight { get; } = 92.90641d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.04025, 30800.0), new Niobium93() } },

        };
    }
}
    
    