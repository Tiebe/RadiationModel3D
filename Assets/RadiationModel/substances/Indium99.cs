using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium99";
        public override double halfLife { get; } = 3.11d;
        public override double atomicWeight { get; } = 98.93411d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8551100.0), new Cadmium99() } },

        };
    }
}
    
    