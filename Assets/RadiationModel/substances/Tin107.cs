using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin107 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin107";
        public override double halfLife { get; } = 174.0d;
        public override double atomicWeight { get; } = 106.91571d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5055000.0), new Indium107() } },

        };
    }
}
    
    