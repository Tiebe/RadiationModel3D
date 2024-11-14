using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium77m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium77m";
        public override double halfLife { get; } = 17.36d;
        public override double atomicWeight { get; } = 76.92009d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00766), new Selenium77() } },

        };
    }
}
    
    