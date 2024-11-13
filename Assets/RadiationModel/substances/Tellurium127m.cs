
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium127m";
        public override double halfLife { get; } = 9167040.0d;
        public override double atomicWeight { get; } = 126.90532d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9786d, new List<RadioactiveSubstance> { new GammaParticle(), new Tellurium127() } },

            { 0.021400000000000002d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine127() } },

        };
    }
}
    
    