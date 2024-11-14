using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine78m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine78m";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 77.92134d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00685), new Bromine78() } },

        };
    }
}
    
    