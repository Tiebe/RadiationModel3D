
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium118";
        public override double halfLife { get; } = 3018.0d;
        public override double atomicWeight { get; } = 117.90692d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium118() } },

        };
    }
}
    
    