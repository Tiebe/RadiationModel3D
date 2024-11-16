using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hydrogen4 : RadioactiveSubstance
    {
        public override string name { get; } = "Hydrogen4";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 4.02643d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new NeutronParticle(), new Hydrogen3() } },

        };
    }
}
    
    