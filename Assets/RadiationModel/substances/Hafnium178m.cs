using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium178m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium178m";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 177.94494d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00108, 1147400.0), new Hafnium178() } },

        };
    }
}
    
    