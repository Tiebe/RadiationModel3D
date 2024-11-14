using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neutron1 : RadioactiveSubstance
    {
        public override string name { get; } = "Neutron1";
        public override double halfLife { get; } = 609.8d;
        public override double atomicWeight { get; } = 1.00866d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 782347.04), new Hydrogen1() } },

        };
    }
}
    
    