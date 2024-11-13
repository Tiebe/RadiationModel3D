
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium79";
        public override double halfLife { get; } = 10319123304000.0d;
        public override double atomicWeight { get; } = 78.9185d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Bromine79() } },

        };
    }
}
    
    