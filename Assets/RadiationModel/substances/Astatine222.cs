
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine222 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine222";
        public override double halfLife { get; } = 54.0d;
        public override double atomicWeight { get; } = 222.02249d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Radon222() } },

        };
    }
}
    
    