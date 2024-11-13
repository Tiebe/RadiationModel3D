
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hydrogen5 : RadioactiveSubstance
    {
        public override string name { get; } = "Hydrogen5";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 5.03531d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new NeutronParticle(), new Hydrogen3() } },

        };
    }
}
    
    