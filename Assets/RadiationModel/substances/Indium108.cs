
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium108";
        public override double halfLife { get; } = 3480.0d;
        public override double atomicWeight { get; } = 107.90969d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium108() } },

        };
    }
}
    
    