
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten188 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten188";
        public override double halfLife { get; } = 6028128.0d;
        public override double atomicWeight { get; } = 187.95849d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhenium188() } },

        };
    }
}
    
    