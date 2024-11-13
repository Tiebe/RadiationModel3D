
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic69 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic69";
        public override double halfLife { get; } = 912.0d;
        public override double atomicWeight { get; } = 68.93225d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium69() } },

        };
    }
}
    
    