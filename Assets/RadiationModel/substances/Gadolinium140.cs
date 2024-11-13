
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium140";
        public override double halfLife { get; } = 15.8d;
        public override double atomicWeight { get; } = 139.93367d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium140() } },

            { 0.67d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium140() } },

            { 0.33d, new List<RadioactiveSubstance> { new Europium140() } },

        };
    }
}
    
    