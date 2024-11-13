
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium243";
        public override double halfLife { get; } = 17839.08d;
        public override double atomicWeight { get; } = 243.062d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Americium243() } },

        };
    }
}
    
    