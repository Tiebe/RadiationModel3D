
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium30 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium30";
        public override double halfLife { get; } = 0.317d;
        public override double atomicWeight { get; } = 29.99047d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Aluminum30() } },

        };
    }
}
    
    