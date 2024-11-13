
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium141";
        public override double halfLife { get; } = 40.7d;
        public override double atomicWeight { get; } = 140.92493d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium141() } },

        };
    }
}
    
    