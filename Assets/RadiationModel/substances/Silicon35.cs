
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon35 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon35";
        public override double halfLife { get; } = 0.78d;
        public override double atomicWeight { get; } = 34.98455d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Phosphorus35() } },

        };
    }
}
    
    