using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium108m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium108m";
        public override double halfLife { get; } = 2376.0d;
        public override double atomicWeight { get; } = 107.90973d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5162400.0), new Cadmium108() } },

        };
    }
}
    
    