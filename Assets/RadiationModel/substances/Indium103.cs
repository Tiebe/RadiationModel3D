
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium103";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 102.91988d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium103() } },

        };
    }
}
    
    