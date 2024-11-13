
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine124 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine124";
        public override double halfLife { get; } = 360806.4d;
        public override double atomicWeight { get; } = 123.90621d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium124() } },

        };
    }
}
    
    