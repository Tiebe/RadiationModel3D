
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen17i : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen17i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 17.01103d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.0042d, new List<RadioactiveSubstance> { new GammaParticle(), new Oxygen17() } },

        };
    }
}
    
    