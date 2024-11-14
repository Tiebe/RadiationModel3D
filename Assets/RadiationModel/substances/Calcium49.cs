using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium49";
        public override double halfLife { get; } = 523.08d;
        public override double atomicWeight { get; } = 48.95566d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5262400.0), new Scandium49() } },

        };
    }
}
    
    