
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium155";
        public override double halfLife { get; } = 2880.0d;
        public override double atomicWeight { get; } = 154.9291d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium155() } },

        };
    }
}
    
    