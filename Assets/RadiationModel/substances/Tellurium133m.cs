
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium133m";
        public override double halfLife { get; } = 3324.0d;
        public override double atomicWeight { get; } = 132.91132d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.835d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine133() } },

            { 0.165d, new List<RadioactiveSubstance> { new GammaParticle(), new Tellurium133() } },

        };
    }
}
    
    