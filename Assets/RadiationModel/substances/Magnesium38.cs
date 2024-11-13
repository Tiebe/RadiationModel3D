
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium38 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium38";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 38.03658d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Aluminum38() } },

        };
    }
}
    
    