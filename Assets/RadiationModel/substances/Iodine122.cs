
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine122 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine122";
        public override double halfLife { get; } = 217.8d;
        public override double atomicWeight { get; } = 121.90759d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium122() } },

            { 0.78d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium122() } },

            { 0.22d, new List<RadioactiveSubstance> { new Tellurium122() } },

        };
    }
}
    
    