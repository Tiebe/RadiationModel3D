using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon203 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon203";
        public override double halfLife { get; } = 44.2d;
        public override double atomicWeight { get; } = 202.99336d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.66d, new List<RadioactiveSubstance> { new AlphaParticle(7652002.09), new Polonium199() } },
            { 0.34d, new List<RadioactiveSubstance> { new BetaParticle(1, 5979000.0), new Astatine203() } },

        };
    }
}
    
    