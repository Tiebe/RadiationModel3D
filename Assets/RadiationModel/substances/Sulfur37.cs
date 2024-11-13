
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur37 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur37";
        public override double halfLife { get; } = 303.0d;
        public override double atomicWeight { get; } = 36.97113d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chlorine37() } },

        };
    }
}
    
    