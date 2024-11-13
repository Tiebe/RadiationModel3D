
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum188 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum188";
        public override double halfLife { get; } = 19.6d;
        public override double atomicWeight { get; } = 187.9636d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tungsten188() } },

        };
    }
}
    
    