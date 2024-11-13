
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten185 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten185";
        public override double halfLife { get; } = 6488640.0d;
        public override double atomicWeight { get; } = 184.95342d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhenium185() } },

        };
    }
}
    
    