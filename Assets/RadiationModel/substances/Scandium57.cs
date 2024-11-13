
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium57";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 56.97705d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium57() } },

        };
    }
}
    
    