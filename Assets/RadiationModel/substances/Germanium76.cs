
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium76 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium76";
        public override double halfLife { get; } = 5.932706975999999e+28d;
        public override double atomicWeight { get; } = 75.9214d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium76() } },

        };
    }
}
    
    