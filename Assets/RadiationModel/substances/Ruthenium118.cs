using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium118";
        public override double halfLife { get; } = 0.099d;
        public override double atomicWeight { get; } = 117.93881d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7887000.0), new Rhodium118() } },

        };
    }
}
    
    