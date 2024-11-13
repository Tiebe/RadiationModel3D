
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus40 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus40";
        public override double halfLife { get; } = 0.15d;
        public override double atomicWeight { get; } = 39.99126d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sulfur40() } },

        };
    }
}
    
    