using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium177n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium177n";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 176.94467d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00092), new Hafnium177() } },

        };
    }
}
    
    