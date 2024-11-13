
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium54";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 53.99447d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Calcium54() } },

        };
    }
}
    
    