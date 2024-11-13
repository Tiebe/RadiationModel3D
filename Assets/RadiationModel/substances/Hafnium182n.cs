
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium182n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium182n";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 181.95332d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Hafnium182() } },

        };
    }
}
    
    