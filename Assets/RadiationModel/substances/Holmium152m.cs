
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium152m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium152m";
        public override double halfLife { get; } = 49.8d;
        public override double atomicWeight { get; } = 151.93189d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.892d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium152() } },

            { 0.10800000000000001d, new List<RadioactiveSubstance> { new AlphaParticle(), new Terbium148() } },

        };
    }
}
    
    