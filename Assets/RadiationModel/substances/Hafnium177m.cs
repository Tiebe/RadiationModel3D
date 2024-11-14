using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium177m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium177m";
        public override double halfLife { get; } = 1.09d;
        public override double atomicWeight { get; } = 176.94464d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00094), new Hafnium177() } },

        };
    }
}
    
    