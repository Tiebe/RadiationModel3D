
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur29 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur29";
        public override double halfLife { get; } = 0.188d;
        public override double atomicWeight { get; } = 28.99668d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Phosphorus29() } },

        };
    }
}
    
    