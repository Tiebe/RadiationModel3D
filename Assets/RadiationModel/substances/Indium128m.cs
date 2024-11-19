using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium128m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium128m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 127.92062d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((247899.99999, 0.005)), new Indium128() } },

        };
    }
}
    
    