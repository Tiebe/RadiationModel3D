using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium207m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium207m";
        public override double halfLife { get; } = 0.057d;
        public override double atomicWeight { get; } = 207.00437d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new List<RadioactiveSubstance> { new GammaParticle((561000.0, 0.00221)), new Radium207() } },

        };
    }
}
    
    