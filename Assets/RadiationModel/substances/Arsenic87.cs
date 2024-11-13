
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic87 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic87";
        public override double halfLife { get; } = 0.492d;
        public override double atomicWeight { get; } = 86.94029d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium87() } },

        };
    }
}
    
    