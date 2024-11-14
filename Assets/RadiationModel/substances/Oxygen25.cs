using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen25 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen25";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 25.02934d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new NeutronParticle(), new Oxygen24() } },

        };
    }
}
    
    