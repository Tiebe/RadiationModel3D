using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium222";
        public override double halfLife { get; } = 546.0d;
        public override double atomicWeight { get; } = 222.02414d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1537000.0), new Astatine222() } },

        };
    }
}
    
    