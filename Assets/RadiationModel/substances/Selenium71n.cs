
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium71n : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium71n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 70.93249d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Selenium71() } },

        };
    }
}
    
    