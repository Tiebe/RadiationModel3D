using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium179n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium179n";
        public override double halfLife { get; } = 2160000.0d;
        public override double atomicWeight { get; } = 178.94701d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00112), new Hafnium179() } },

        };
    }
}
    
    