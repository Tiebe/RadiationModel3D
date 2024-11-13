
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium147m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium147m";
        public override double halfLife { get; } = 55.2d;
        public override double atomicWeight { get; } = 146.93189d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.6890000000000001d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium147() } },

            { 0.311d, new List<RadioactiveSubstance> { new GammaParticle(), new Dysprosium147() } },

        };
    }
}
    
    