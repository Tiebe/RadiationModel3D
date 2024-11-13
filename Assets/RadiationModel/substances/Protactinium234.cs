
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium234";
        public override double halfLife { get; } = 24120.0d;
        public override double atomicWeight { get; } = 234.04331d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Uranium234() } },

        };
    }
}
    
    