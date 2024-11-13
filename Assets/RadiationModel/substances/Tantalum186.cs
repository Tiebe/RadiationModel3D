
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum186 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum186";
        public override double halfLife { get; } = 630.0d;
        public override double atomicWeight { get; } = 185.95855d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tungsten186() } },

        };
    }
}
    
    