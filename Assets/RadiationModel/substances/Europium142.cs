
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium142";
        public override double halfLife { get; } = 2.36d;
        public override double atomicWeight { get; } = 141.92345d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium142() } },

            { 0.899d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium142() } },

            { 0.10099999999999999d, new List<RadioactiveSubstance> { new Samarium142() } },

        };
    }
}
    
    