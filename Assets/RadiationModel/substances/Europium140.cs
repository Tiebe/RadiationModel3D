using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium140";
        public override double halfLife { get; } = 1.51d;
        public override double atomicWeight { get; } = 139.92808d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8466000.0), new Samarium140() } },
            { 0.951d, new List<RadioactiveSubstance> { new BetaParticle(1, 8466000.0), new Samarium140() } },
            { 0.049d, new List<RadioactiveSubstance> { new Samarium140() } },

        };
    }
}
    
    