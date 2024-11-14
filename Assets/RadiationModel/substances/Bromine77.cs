using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine77 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine77";
        public override double halfLife { get; } = 205344.0d;
        public override double atomicWeight { get; } = 76.92138d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1364700.0), new Selenium77() } },

        };
    }
}
    
    