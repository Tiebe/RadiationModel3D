
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium155";
        public override double halfLife { get; } = 35640.0d;
        public override double atomicWeight { get; } = 154.92576d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium155() } },

        };
    }
}
    
    