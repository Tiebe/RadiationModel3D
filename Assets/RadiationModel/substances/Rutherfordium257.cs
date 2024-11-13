
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium257";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 257.10292d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.893d, new List<RadioactiveSubstance> { new AlphaParticle(), new Nobelium253() } },

            { 0.094d, new List<RadioactiveSubstance> { new BetaParticle(), new Lawrencium257() } },

            { 0.013000000000000001d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    