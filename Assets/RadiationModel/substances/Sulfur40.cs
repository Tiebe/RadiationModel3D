
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur40 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur40";
        public override double halfLife { get; } = 8.8d;
        public override double atomicWeight { get; } = 39.97548d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chlorine40() } },

        };
    }
}
    
    