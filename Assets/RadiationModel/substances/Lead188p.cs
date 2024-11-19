using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead188p : RadioactiveSubstance
    {
        public override string name { get; } = "Lead188p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 187.98601d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((4783000.0, 0.00026)), new Lead188() } },

        };
    }
}
    
    