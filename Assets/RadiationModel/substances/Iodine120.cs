
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine120 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine120";
        public override double halfLife { get; } = 4900.2d;
        public override double atomicWeight { get; } = 119.91009d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium120() } },

        };
    }
}
    
    