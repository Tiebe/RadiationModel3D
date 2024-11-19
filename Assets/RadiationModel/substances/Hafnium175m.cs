using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium175m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium175m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 174.94165d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00985, 125900.0), new Hafnium175() } },

        };
    }
}
    
    