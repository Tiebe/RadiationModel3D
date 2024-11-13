
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt76 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt76";
        public override double halfLife { get; } = 0.023d;
        public override double atomicWeight { get; } = 75.97245d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel76() } },

        };
    }
}
    
    